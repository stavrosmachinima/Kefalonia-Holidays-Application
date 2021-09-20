using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allhlepidrash
{
    public static class soundPlayer
    {

        private static SoundPlayer _soundPlayer;
        private static bool _sound;

        static soundPlayer()
        {
            try
            {
                _soundPlayer = new SoundPlayer("..//..//..//audio//jazz.wav");
                // boolean gia na doume an akougetai kati
                _sound = true;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Αποτυχιά σύνδεσης λόγω" + ex.Message);
            }
        }
        public static SoundPlayer soundVariable
        {
            get { return _soundPlayer; }
        }
        public static bool doYouHearMusic
        {
            get { return _sound; }
            set { _sound = value; }
        }
    }
}
