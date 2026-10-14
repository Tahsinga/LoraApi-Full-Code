using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale.My.Resources
{
	// Token: 0x02000073 RID: 115
	[StandardModule]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[HideModuleName]
	internal sealed class Resources
	{
		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x000EEA18 File Offset: 0x000ECC18
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = object.ReferenceEquals(Resources.resourceMan, null);
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("PointOfSale.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x000EEA60 File Offset: 0x000ECC60
		// (set) Token: 0x060019DE RID: 6622 RVA: 0x000EEA77 File Offset: 0x000ECC77
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x000EEA80 File Offset: 0x000ECC80
		internal static Bitmap Logo
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Logo", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x000EEAB4 File Offset: 0x000ECCB4
		internal static Bitmap numeric_keypad
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("numeric_keypad", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x000EEAE8 File Offset: 0x000ECCE8
		internal static Bitmap numeric_keypad3
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("numeric_keypad3", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x000EEB1C File Offset: 0x000ECD1C
		internal static Bitmap Quantum
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Quantum", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x000EEB50 File Offset: 0x000ECD50
		internal static Bitmap QuantumPOS_Logo
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("QuantumPOS Logo", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x000EEB84 File Offset: 0x000ECD84
		internal static Bitmap QuantumPOS_Logo2
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("QuantumPOS Logo2", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x000EEBB8 File Offset: 0x000ECDB8
		internal static Bitmap refresh
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("refresh", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x000EEBEC File Offset: 0x000ECDEC
		internal static Bitmap server
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("server", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x000EEC20 File Offset: 0x000ECE20
		internal static Bitmap TigerWeb_Logo
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("TigerWeb Logo", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x000EEC54 File Offset: 0x000ECE54
		internal static Bitmap TigerWeb_Logo2
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("TigerWeb Logo2", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x04000C7F RID: 3199
		private static ResourceManager resourceMan;

		// Token: 0x04000C80 RID: 3200
		private static CultureInfo resourceCulture;
	}
}
