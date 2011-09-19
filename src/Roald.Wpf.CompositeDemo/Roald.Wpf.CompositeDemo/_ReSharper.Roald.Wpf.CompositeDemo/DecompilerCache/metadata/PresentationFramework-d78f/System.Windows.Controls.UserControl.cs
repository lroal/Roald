// Type: System.Windows.Controls.UserControl
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\PresentationFramework.dll

using System.Runtime;
using System.Windows.Automation.Peers;

namespace System.Windows.Controls
{
    public class UserControl : ContentControl
    {
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public UserControl();

        protected override AutomationPeer OnCreateAutomationPeer();
    }
}
