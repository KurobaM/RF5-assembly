using System;
using Define;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x020010F8 RID: 4344
	[Token(Token = "0x2000AED")]
	[Serializable]
	public struct FocusObjectDataTable
	{
		// Token: 0x040180AA RID: 98474
		[Token(Token = "0x4014B8A")]
		[FieldOffset(Offset = "0x0")]
		public FocusObjectID DataID;

		// Token: 0x040180AB RID: 98475
		[Token(Token = "0x4014B8B")]
		[FieldOffset(Offset = "0x8")]
		public string NameID;

		// Token: 0x040180AC RID: 98476
		[Token(Token = "0x4014B8C")]
		[FieldOffset(Offset = "0x10")]
		public ObjectType ObjectType;

		// Token: 0x040180AD RID: 98477
		[Token(Token = "0x4014B8D")]
		[FieldOffset(Offset = "0x14")]
		public GameFlagData GameFlag;
	}
}
