using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EltradeFPAx
{
	// Token: 0x02000221 RID: 545
	[CompilerGenerated]
	[Guid("34B211BB-165D-434D-90E2-86DCE1D73125")]
	[TypeIdentifier]
	[ComImport]
	public interface IEltradeFprn
	{
		// Token: 0x060061C6 RID: 25030
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int Init([In] int ComPort, [In] int PortSpeed, [In] int DevAddress, [In] int Locale, [In] int Language, [MarshalAs(UnmanagedType.BStr)] [In] string SerialKey);

		// Token: 0x060061C7 RID: 25031
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Close();

		// Token: 0x060061C8 RID: 25032
		void _VtblGap1_1();

		// Token: 0x060061C9 RID: 25033
		[DispId(4)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string GetLastError([In] int LngCode);

		// Token: 0x060061CA RID: 25034
		[DispId(5)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int StartBon([In] int BonType, [In] int PLUNumbering, [MarshalAs(UnmanagedType.BStr)] [In] string CashierName, [MarshalAs(UnmanagedType.BStr)] [In] string InvNumber, [MarshalAs(UnmanagedType.BStr)] [In] string InvTaxNumber, [MarshalAs(UnmanagedType.BStr)] [In] string InvVATNumber, [MarshalAs(UnmanagedType.BStr)] [In] string InvCompany, [MarshalAs(UnmanagedType.BStr)] [In] string InvCity, [MarshalAs(UnmanagedType.BStr)] [In] string InvAddress, [MarshalAs(UnmanagedType.BStr)] [In] string InvMOL, [MarshalAs(UnmanagedType.BStr)] [In] string InvReceiver);

		// Token: 0x060061CB RID: 25035
		[DispId(6)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int EndBon();

		// Token: 0x060061CC RID: 25036
		[DispId(7)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int AddPLU([MarshalAs(UnmanagedType.BStr)] [In] string Numb, [MarshalAs(UnmanagedType.BStr)] [In] string Name, [In] double Price, [In] double Quantity, [In] int VATGroup);

		// Token: 0x060061CD RID: 25037
		void _VtblGap2_3();

		// Token: 0x060061CE RID: 25038
		[DispId(11)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int AddPayment([In] int Number, [MarshalAs(UnmanagedType.BStr)] [In] string Name, [In] double Ammount, [In] double Cource);

		// Token: 0x060061CF RID: 25039
		void _VtblGap3_6();

		// Token: 0x060061D0 RID: 25040
		[DispId(201)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string GetLastInvoiceNumber();

		// Token: 0x060061D1 RID: 25041
		void _VtblGap4_14();

		// Token: 0x060061D2 RID: 25042
		[DispId(152)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int RunXReport();

		// Token: 0x060061D3 RID: 25043
		[DispId(153)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int RunZReport();

		// Token: 0x060061D4 RID: 25044
		void _VtblGap5_1();

		// Token: 0x060061D5 RID: 25045
		[DispId(155)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int RunPrinterTest();

		// Token: 0x060061D6 RID: 25046
		void _VtblGap6_13();

		// Token: 0x17002367 RID: 9063
		// (get) Token: 0x060061D7 RID: 25047
		// (set) Token: 0x060061D8 RID: 25048
		[DispId(224)]
		int CurrencyID
		{
			[DispId(224)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[DispId(224)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		// Token: 0x17002368 RID: 9064
		// (get) Token: 0x060061D9 RID: 25049
		// (set) Token: 0x060061DA RID: 25050
		[DispId(225)]
		int PLUCurrencyID
		{
			[DispId(225)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[DispId(225)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}
	}
}
