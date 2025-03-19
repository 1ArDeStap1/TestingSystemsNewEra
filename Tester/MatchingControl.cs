using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class MatchingControl : UserControl
    {

        private Dictionary<string, string> correctPairs = new Dictionary<string, string>();
        private Dictionary<string, ComboBox> userAnswers = new Dictionary<string, ComboBox>();

        public MatchingControl()
        {
            InitializeComponent();
        }

        public void LoadPairs(Dictionary<string, string> pairs)
        {
            correctPairs = pairs;
            userAnswers.Clear();
            this.Controls.Clear();

            int y = 10;

            List<string> rightItems = new List<string>(pairs.Values);
            rightItems = rightItems.OrderBy(a => Guid.NewGuid()).ToList(); // Перемешивание вариантов

            foreach (var pair in pairs)
            {
                Label leftLabel = new Label { Text = pair.Key, Location = new System.Drawing.Point(10, y), AutoSize = true };
                ComboBox comboBox = new ComboBox { Location = new System.Drawing.Point(150, y), Width = 150 };
                comboBox.Items.AddRange(rightItems.ToArray());
                this.Controls.Add(leftLabel);
                this.Controls.Add(comboBox);

                userAnswers[pair.Key] = comboBox;
                y += 30;
            }
        }

        /// <summary>
        /// Проверяет, правильно ли выбраны соответствия
        /// </summary>
        public bool CheckAnswers()
        {
            foreach (var pair in correctPairs)
            {
                if (userAnswers[pair.Key].SelectedItem == null || userAnswers[pair.Key].SelectedItem.ToString() != pair.Value)
                    return false;
            }
            return true;
        }


  

        public MatchingControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
