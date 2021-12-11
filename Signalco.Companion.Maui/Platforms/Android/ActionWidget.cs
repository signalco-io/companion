using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;

namespace Signalco.Companion.Maui.Platforms.Android
{
    [BroadcastReceiver(Label = "@string/action_widget_name")]
    [MetaData ("android.appwidget.provider", Resource = "@xml/widget_word")]
    internal class ActionWidget
    {
    }
}
