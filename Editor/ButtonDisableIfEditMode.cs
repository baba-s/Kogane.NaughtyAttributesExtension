using NaughtyAttributes;

namespace Kogane
{
    public sealed class ButtonDisableIfEditMode : ButtonAttribute
    {
        public ButtonDisableIfEditMode( string text ) : base( text, EButtonEnableMode.Playmode )
        {
        }

        public ButtonDisableIfEditMode() : this( null )
        {
        }
    }
}