using System;
using Il2CppDummyDll;

namespace nn.swkbd
{
	// Token: 0x020014F6 RID: 5366
	// (Invoke) Token: 0x06007A27 RID: 31271
	[Token(Token = "0x2000EB9")]
	[Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x156CF0", Offset = "0x156DF1")]
	public delegate TextCheckResult TextCheckCallback(IntPtr pOutDialogTextBuf, ref long pOutDialogTextLengthSize, ref String pStr);
}
