using DocumentFormat.OpenXml.Office.CoverPageProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.AnimationClasses
{
    public class Animation
    {

        public int StepDivider = 10;

        public string ID { get; set; }

        public float Value;

        public float StartValue;

        private float targetValue;
        public float TargetValue
        {
            get => targetValue;
            set
            {
                targetValue = value;
                Reverse = value < Value ? true : false;
            }
        }

        public float Volume;

        public bool Reverse = false;

        public AnimationStatus Status { get; set; }
        public enum AnimationStatus
        {
            Requested,
            Running,
            Completed
        }

        private float p15, p30, p70, p85;

        private float ValueByPercent(float percent){ 
            float COEFF = percent / 100;
            float VolumeInPercent = Volume / COEFF;
            float VolumeOutPercent = StartValue + VolumeInPercent;

            return VolumeOutPercent;     
        }

        public float Step()
        {
            float basicSteps = Math.Abs(Volume) / StepDivider;
            float resultSteps = basicSteps;

            if (!Reverse)
            {
                if (Value <= p15 || Value >= p85)
                {
                    resultSteps = basicSteps / 3.5f;
                }else if (Value <= p30 || Value >= p70)
                {
                    resultSteps = basicSteps / 2f;
                }
                else if (Value > p30 && p70 < Value)
                {
                    resultSteps = basicSteps;                     
                }
            } else
            {
                if (Value >= p15 || Value <= p85)
                {
                    resultSteps = basicSteps / 3.5f;
                }
                else if (Value >= p30 || Value <= p70)
                {
                    resultSteps = basicSteps / 2f;
                }
                else if (Value < p30 && p70 > Value)
                {
                    resultSteps = basicSteps;
                }
            }

            return Math.Abs(resultSteps);

        }

        public delegate void ControlMethod();
        private ControlMethod InvalidateControl;

        public void UpdateFrame()
        {
            Status = AnimationStatus.Running;

            if (Reverse == false)
            {
                if (Value <= targetValue)
                {
                    Value += Step();

                    if (Value >= targetValue)
                    {
                        Value = targetValue;
                        Status = AnimationStatus.Completed;
                    }
                } 
            }
            else
            {

                if (Value >= targetValue)
                {
                    Value -= Step();

                    if (Value <= targetValue)
                    {
                        Value = targetValue;
                        Status = AnimationStatus.Completed;
                    }
                }

            }

            InvalidateControl.Invoke();

        }


        public Animation() { }

        public Animation(string ID, ControlMethod InvalidateControl, float Value, float TargetValue) {

            this.ID = ID;

            this.InvalidateControl = InvalidateControl;

            this.Value = Value;
            this.TargetValue = TargetValue;

            

            StartValue = Value;
            Volume = TargetValue - Value;

            p15 = ValueByPercent(15);
            p30 = ValueByPercent(30);
            p70 = ValueByPercent(70);
            p85 = ValueByPercent(85);

        }

    }
}
