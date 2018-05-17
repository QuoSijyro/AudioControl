using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioControl
{
    static class AudioManager
    {
        /// <summary>
        /// This method will change the volume level of a specific process
        /// </summary>
        /// <param name="applicationName">Name of the process to set the volume, for example Spotify.exe</param>
        /// <param name="level">Sound level to set, 0.2 will set 20% of the master volume</param>
        static public void SetApplicationVolume(string applicationName, double level)
        {
            Process.Start("nircmd.exe", "setappvolume " + applicationName + " " + level);
        }

        /// <summary>
        /// This method will increase the volume level of a specific process
        /// </summary>
        /// <param name="applicationName">Name of the process to set the volume, for example Spotify.exe</param>
        /// <param name="level">Sound level to increase, 0.2 will increase by 20% the volume</param>
        static public void IncreaseApplicationVolume(string applicationName, double level)
        {
            Process.Start("nircmd.exe", "changeappvolume " + applicationName + " +" + level);
        }

        /// <summary>
        /// This method will decrase the volume level of a specific process
        /// </summary>
        /// <param name="applicationName">Name of the process to set the volume, for example Spotify.exe</param>
        /// <param name="level">Sound level to decrease, 0.2 will decrease by 20% the volume</param>
        static public void DecreaseApplicationVolume(string applicationName, double level)
        {
            Process.Start("nircmd.exe", "changeappvolume " + applicationName + " -" + level);
        }

        /*
        static public void MuteApplication(string applicationName, bool value)
        {
            Process.Start("nircmd.exe", "muteappvolume " + applicationName + " " + bool.value);
        }
        */
    }
}
