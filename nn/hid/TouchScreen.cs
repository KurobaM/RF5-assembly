using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x020015A0 RID: 5536
	[Token(Token = "0x2000F2D")]
	public static class TouchScreen
	{
		// Token: 0x06007D97 RID: 32151
		[Token(Token = "0x6006813")]
		[Address(RVA = "0x2D62F00", Offset = "0x2D63001", VA = "0x2D62F00")]
		[PreserveSig]
		public static extern void Initialize();

		// Token: 0x06007D98 RID: 32152
		[Token(Token = "0x6006814")]
		[Address(RVA = "0x2D62F10", Offset = "0x2D63011", VA = "0x2D62F10")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState1 pOutValue);

		// Token: 0x06007D99 RID: 32153
		[Token(Token = "0x6006815")]
		[Address(RVA = "0x2D62F20", Offset = "0x2D63021", VA = "0x2D62F20")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState2 pOutValue);

		// Token: 0x06007D9A RID: 32154
		[Token(Token = "0x6006816")]
		[Address(RVA = "0x2D62F30", Offset = "0x2D63031", VA = "0x2D62F30")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState3 pOutValue);

		// Token: 0x06007D9B RID: 32155
		[Token(Token = "0x6006817")]
		[Address(RVA = "0x2D62F40", Offset = "0x2D63041", VA = "0x2D62F40")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState4 pOutValue);

		// Token: 0x06007D9C RID: 32156
		[Token(Token = "0x6006818")]
		[Address(RVA = "0x2D62F50", Offset = "0x2D63051", VA = "0x2D62F50")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState5 pOutValue);

		// Token: 0x06007D9D RID: 32157
		[Token(Token = "0x6006819")]
		[Address(RVA = "0x2D62F60", Offset = "0x2D63061", VA = "0x2D62F60")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState6 pOutValue);

		// Token: 0x06007D9E RID: 32158
		[Token(Token = "0x600681A")]
		[Address(RVA = "0x2D62F70", Offset = "0x2D63071", VA = "0x2D62F70")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState7 pOutValue);

		// Token: 0x06007D9F RID: 32159
		[Token(Token = "0x600681B")]
		[Address(RVA = "0x2D62F80", Offset = "0x2D63081", VA = "0x2D62F80")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState8 pOutValue);

		// Token: 0x06007DA0 RID: 32160
		[Token(Token = "0x600681C")]
		[Address(RVA = "0x2D62F90", Offset = "0x2D63091", VA = "0x2D62F90")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState9 pOutValue);

		// Token: 0x06007DA1 RID: 32161
		[Token(Token = "0x600681D")]
		[Address(RVA = "0x2D62FA0", Offset = "0x2D630A1", VA = "0x2D62FA0")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState10 pOutValue);

		// Token: 0x06007DA2 RID: 32162
		[Token(Token = "0x600681E")]
		[Address(RVA = "0x2D62FB0", Offset = "0x2D630B1", VA = "0x2D62FB0")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState11 pOutValue);

		// Token: 0x06007DA3 RID: 32163
		[Token(Token = "0x600681F")]
		[Address(RVA = "0x2D62FC0", Offset = "0x2D630C1", VA = "0x2D62FC0")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState12 pOutValue);

		// Token: 0x06007DA4 RID: 32164
		[Token(Token = "0x6006820")]
		[Address(RVA = "0x2D62FD0", Offset = "0x2D630D1", VA = "0x2D62FD0")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState13 pOutValue);

		// Token: 0x06007DA5 RID: 32165
		[Token(Token = "0x6006821")]
		[Address(RVA = "0x2D62FE0", Offset = "0x2D630E1", VA = "0x2D62FE0")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState14 pOutValue);

		// Token: 0x06007DA6 RID: 32166
		[Token(Token = "0x6006822")]
		[Address(RVA = "0x2D62FF0", Offset = "0x2D630F1", VA = "0x2D62FF0")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState15 pOutValue);

		// Token: 0x06007DA7 RID: 32167
		[Token(Token = "0x6006823")]
		[Address(RVA = "0x2D63000", Offset = "0x2D63101", VA = "0x2D63000")]
		[PreserveSig]
		public static extern void GetState(ref TouchScreenState16 pOutValue);

		// Token: 0x06007DA8 RID: 32168
		[Token(Token = "0x6006824")]
		[Address(RVA = "0x2D63010", Offset = "0x2D63111", VA = "0x2D63010")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState1[] pOutValues, int count);

		// Token: 0x06007DA9 RID: 32169
		[Token(Token = "0x6006825")]
		[Address(RVA = "0x2D63130", Offset = "0x2D63231", VA = "0x2D63130")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState2[] pOutValues, int count);

		// Token: 0x06007DAA RID: 32170
		[Token(Token = "0x6006826")]
		[Address(RVA = "0x2D63250", Offset = "0x2D63351", VA = "0x2D63250")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState3[] pOutValues, int count);

		// Token: 0x06007DAB RID: 32171
		[Token(Token = "0x6006827")]
		[Address(RVA = "0x2D63380", Offset = "0x2D63481", VA = "0x2D63380")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState4[] pOutValues, int count);

		// Token: 0x06007DAC RID: 32172
		[Token(Token = "0x6006828")]
		[Address(RVA = "0x2D634B0", Offset = "0x2D635B1", VA = "0x2D634B0")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState5[] pOutValues, int count);

		// Token: 0x06007DAD RID: 32173
		[Token(Token = "0x6006829")]
		[Address(RVA = "0x2D635E0", Offset = "0x2D636E1", VA = "0x2D635E0")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState6[] pOutValues, int count);

		// Token: 0x06007DAE RID: 32174
		[Token(Token = "0x600682A")]
		[Address(RVA = "0x2D63730", Offset = "0x2D63831", VA = "0x2D63730")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState7[] pOutValues, int count);

		// Token: 0x06007DAF RID: 32175
		[Token(Token = "0x600682B")]
		[Address(RVA = "0x2D63860", Offset = "0x2D63961", VA = "0x2D63860")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState8[] pOutValues, int count);

		// Token: 0x06007DB0 RID: 32176
		[Token(Token = "0x600682C")]
		[Address(RVA = "0x2D63990", Offset = "0x2D63A91", VA = "0x2D63990")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState9[] pOutValues, int count);

		// Token: 0x06007DB1 RID: 32177
		[Token(Token = "0x600682D")]
		[Address(RVA = "0x2D63AC0", Offset = "0x2D63BC1", VA = "0x2D63AC0")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState10[] pOutValues, int count);

		// Token: 0x06007DB2 RID: 32178
		[Token(Token = "0x600682E")]
		[Address(RVA = "0x2D63BF0", Offset = "0x2D63CF1", VA = "0x2D63BF0")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState11[] pOutValues, int count);

		// Token: 0x06007DB3 RID: 32179
		[Token(Token = "0x600682F")]
		[Address(RVA = "0x2D63D20", Offset = "0x2D63E21", VA = "0x2D63D20")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState12[] pOutValues, int count);

		// Token: 0x06007DB4 RID: 32180
		[Token(Token = "0x6006830")]
		[Address(RVA = "0x2D63E40", Offset = "0x2D63F41", VA = "0x2D63E40")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState13[] pOutValues, int count);

		// Token: 0x06007DB5 RID: 32181
		[Token(Token = "0x6006831")]
		[Address(RVA = "0x2D63F70", Offset = "0x2D64071", VA = "0x2D63F70")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState14[] pOutValues, int count);

		// Token: 0x06007DB6 RID: 32182
		[Token(Token = "0x6006832")]
		[Address(RVA = "0x2D640A0", Offset = "0x2D641A1", VA = "0x2D640A0")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState15[] pOutValues, int count);

		// Token: 0x06007DB7 RID: 32183
		[Token(Token = "0x6006833")]
		[Address(RVA = "0x2D641D0", Offset = "0x2D642D1", VA = "0x2D641D0")]
		[PreserveSig]
		public static extern int GetStates([Out] TouchScreenState16[] pOutValues, int count);

		// Token: 0x0401C0AB RID: 114859
		[Token(Token = "0x4018915")]
		public const int TouchCountMax = 16;

		// Token: 0x0401C0AC RID: 114860
		[Token(Token = "0x4018916")]
		public const int StateCountMax = 16;
	}
}
