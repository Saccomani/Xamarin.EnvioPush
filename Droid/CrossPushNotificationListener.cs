using System;
using PushNotification.Plugin;
using PushNotification.Plugin.Abstractions;

namespace TesteNotificacao.Droid
{
	public class CrossPushNotificationListener : IPushNotificationListener

	{
		public CrossPushNotificationListener()
		{
		}

		public void OnError(string message, DeviceType deviceType)
		{

		}

		public void OnMessage(global::Newtonsoft.Json.Linq.JObject values, DeviceType deviceType)
		{
	
		}

		public void OnRegistered(string token, DeviceType deviceType)
		{
			
		}

		public void OnUnregistered(DeviceType deviceType)
		{
			
		}

		public bool ShouldShowNotification()
		{
			return true;
		}
	}
}
