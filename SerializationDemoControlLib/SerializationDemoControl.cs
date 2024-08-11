using System.ComponentModel;
using System.Text;

namespace SerializationDemoControlLib
{
    public partial class SerializationDemoControl : UserControl
    {
        // This field backs the Strings property.
        private String[] stringsValue = new String[1];
        // When the DesignerSerializationVisibility attribute has
        // a value of "Content" or "Visible" the designer will
        // serialize the property. This property can also be edited
        // at design time with a CollectionEditor.
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Content)]
        public String[] Strings
        {
            get
            {
                return this.stringsValue;
            }
            set
            {
                this.stringsValue = value;

                // Populate the contained TextBox with the values
                // in the stringsValue array.
                StringBuilder sb =
                    new StringBuilder(this.stringsValue.Length);

                for (int i = 0; i < this.stringsValue.Length; i++)
                {
                    sb.Append(this.stringsValue[i]);
                    sb.Append("\r\n");
                }

                this.textBox1.Text = sb.ToString();
            }
        }
        public SerializationDemoControl()
        {
            InitializeComponent();
        }
    }
}
