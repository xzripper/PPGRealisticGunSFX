using System;

using UnityEngine;

// GunSFX Mod.
namespace GunSFX {
    public class GunSFX {
        public static void Main() {
            string[] ShotSounds = {"sfx/OneShot.mp3", "sfx/SecondShot.mp3", "sfx/ThirdShot.mp3"};

            var RandomInstance = new System.Random();

            var ChosenShotSound = ShotSounds[RandomInstance.Next(ShotSounds.Length)];

            var ShotSound = ModAPI.LoadSound(ChosenShotSound);

            ModAPI.OnGunShot += (sender, gun) => {
                gun.GetComponent<AudioSource>().clip = ShotSound;
                gun.GetComponent<AudioSource>().Play();
            };
        }
    }
}
