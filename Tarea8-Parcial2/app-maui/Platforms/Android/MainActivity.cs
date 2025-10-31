using Android.App;
using Android.Content.PM;
using Android.OS;
using System.Linq;

namespace Tarea8Parcial2
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        const int RequestPermissionsCode = 1000;

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestRuntimePermissions();
        }

        private void RequestRuntimePermissions()
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
            {
                var permissions = new[]
                {
                    Android.Manifest.Permission.RecordAudio,
                    Android.Manifest.Permission.Camera,
                    Android.Manifest.Permission.ModifyAudioSettings
                };

                if (Build.VERSION.SdkInt >= BuildVersionCodes.Tiramisu)
                {
                    permissions = permissions.Concat(new[]
                    {
                        Android.Manifest.Permission.ReadMediaImages,
                        Android.Manifest.Permission.ReadMediaVideo,
                        Android.Manifest.Permission.ReadMediaAudio
                    }).ToArray();
                }
                else
                {
                    permissions = permissions.Concat(new[]
                    {
                        Android.Manifest.Permission.ReadExternalStorage,
                        Android.Manifest.Permission.WriteExternalStorage
                    }).ToArray();
                }

                RequestPermissions(permissions, RequestPermissionsCode);
            }
        }
    }
}
