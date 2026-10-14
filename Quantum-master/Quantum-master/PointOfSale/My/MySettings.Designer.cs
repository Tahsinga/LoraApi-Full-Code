using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale.My
{
	// Token: 0x02000074 RID: 116
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x060019EB RID: 6635 RVA: 0x000EECB4 File Offset: 0x000ECEB4
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			bool saveMySettingsOnExit = MyProject.Application.SaveMySettingsOnExit;
			if (saveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x000EECE0 File Offset: 0x000ECEE0
		public static MySettings Default
		{
			get
			{
				bool flag = !MySettings.addedHandler;
				if (flag)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						bool flag3 = !MySettings.addedHandler;
						if (flag3)
						{
							MyProject.Application.Shutdown += MySettings.AutoSaveSettings;
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x000EED6C File Offset: 0x000ECF6C
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=SIMBA-PC;Initial Catalog=POS;Integrated Security=True")]
		public string POSConnectionString
		{
			get
			{
				return Conversions.ToString(this["POSConnectionString"]);
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x000EED90 File Offset: 0x000ECF90
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=QUANTUMPC\\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True")]
		public string POSConnectionString1
		{
			get
			{
				return Conversions.ToString(this["POSConnectionString1"]);
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x000EEDB4 File Offset: 0x000ECFB4
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=Quantum-Busines\\SQLExpress;Initial Catalog=POS;Integrated Security=True")]
		public string POSConnectionString2
		{
			get
			{
				return Conversions.ToString(this["POSConnectionString2"]);
			}
		}

		// Token: 0x04000C81 RID: 3201
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04000C82 RID: 3202
		private static bool addedHandler;

		// Token: 0x04000C83 RID: 3203
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
