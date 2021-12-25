namespace WMPLib
{
    internal class WindowsMediaPlayer
    {
        internal string URL;

        public WindowsMediaPlayer()
        {
        }

        public object controls { get; internal set; }
        public int PlayStateChange { get; internal set; }
    }
}