using NaughtyAttributes;

namespace Kogane
{
    public sealed class ButtonEnableIfPlayMode : ButtonAttribute
    {
        public ButtonEnableIfPlayMode( string text ) : base( text, EButtonEnableMode.Playmode )
        {
        }

        public ButtonEnableIfPlayMode() : this( null )
        {
        }
    }
}