using System.Text;

namespace MetaStudentAdmin.MetadataModel
{
    internal abstract class Component
    {
        public string BuildHtml()
        {
            var sb = new StringBuilder();
            sb.Append("class ");
            sb.Append(GetType().Name);
            sb.Append(@" extends BaseComponent { 
                constructor() {
                    super();
                    this.setStyle(this.getStyle());
                    this.updateView();
                }
            ");
            sb.Append("}");

            return sb.ToString();
        }
    }
}
