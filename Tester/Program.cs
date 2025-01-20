using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

#if DEBUG == false

            String DbPath = Directory.GetCurrentDirectory();
            String PathToDB = Path.Combine(DbPath, "TesterProgramDataBase");
            AppDomain.CurrentDomain.SetData("DataDirectory", PathToDB);  

//#elif DEBUG == true

            String PathToDB = @"G:\DataBaseViaTest";
            AppDomain.CurrentDomain.SetData("DataDirectory", PathToDB);

#endif


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }

        static public Image SelectImage(float maxWidth = 0, float maxHeight = 0)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                Image resultImage = Image.FromFile(of.FileName);
                var rate = (maxWidth / resultImage.Width);
                if (maxWidth > 0)
                    if (resultImage.Width > maxWidth)
                        resultImage = (Image)(new Bitmap(resultImage,
                            new Size(Convert.ToInt32(resultImage.Width * rate),
                                     Convert.ToInt32(resultImage.Height * rate)
                        )));

                /*if (maxHeight > 0)
                    if (resultImage.Height > maxHeight)
                    {
                        rate = maxHeight / resultImage.Height;
                        resultImage = (Image)(new Bitmap(resultImage,
                            new Size(Convert.ToInt32(resultImage.Width * rate),
                                     Convert.ToInt32(resultImage.Height * rate)
                        )));
                    }*/
                return resultImage;
            }
            return null;
        }

        public static void MessageRegistered()
        {
            MessageBox.Show("Вы успешно зарегистрировались, теперь вы можете авторизоваться используюя свой логин и пароль.");
        }

        public static void MessageCreated()
        {
            MessageBox.Show("Операция проведена успешно.");
        }

        public static void MessageError(Exception ex = null)
        {
            MessageBox.Show("Во время совершения операции произошла ошибка, проверьте входные данные.");
            if (ex != null)
                Debug.WriteLine(ex.Message);
        }

        public static IEnumerable<T> RandomizeList<T>(this IEnumerable<T> source)
        {
            Random rnd = new Random();
            return source.OrderBy<T, int>((item) => rnd.Next());
        }
    }
}
