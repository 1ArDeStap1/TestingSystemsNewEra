using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.AnimationClasses
{
    public static class Animator
    {

        public static List<Animation> AnimationList = new List<Animation>();

        public static int AnimationCount()
        { 
            return AnimationList.Count; 
        }

        private static Thread AnimationThread;

        public static double interval;

        public static void Start()
        {
            interval = 16;

            AnimationThread = new Thread(AnimationInvoker)
            {
                IsBackground = true,
                Name = "MyAnimation"
            };

            AnimationThread.Start();


        }

        public static void AnimationInvoker() {
            while (true)
            {
                AnimationList.RemoveAll(a => a.Status == Animation.AnimationStatus.Completed);

                Parallel.For(0, AnimationCount(), index =>
                {
                    AnimationList[index].UpdateFrame();
                });

                Thread.Sleep((int)interval);
            }
        }

        public static void Request(Animation Anim, bool ReplaceIfExist) { 
        
            Anim.Status = Animation.AnimationStatus.Requested;

            Animation dupAnim = GetDuplicate(Anim);

            if (dupAnim != null)
            {
                if (ReplaceIfExist == true)
                {
                    dupAnim.Status = Animation.AnimationStatus.Completed;
                }
                else
                {
                    return;
                }
            }

            AnimationList.Add(Anim);

        }


        private static Animation GetDuplicate(Animation Anim)
        {
            return AnimationList.Find(a => a.ID == Anim.ID);

        }

    }
}
