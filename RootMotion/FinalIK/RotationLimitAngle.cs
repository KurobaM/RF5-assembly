using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D74 RID: 3444
	[Token(Token = "0x20008D5")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x148790", Offset = "0x148891")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148790", Offset = "0x148891")]
	public class RotationLimitAngle : RotationLimit
	{
		// Token: 0x0600596F RID: 22895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A25")]
		[Address(RVA = "0x27CB720", Offset = "0x27CB821", VA = "0x27CB720")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB4F0", Offset = "0x1AB5F1")]
		private void OpenUserManual()
		{
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A26")]
		[Address(RVA = "0x27CB770", Offset = "0x27CB871", VA = "0x27CB770")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB530", Offset = "0x1AB631")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A27")]
		[Address(RVA = "0x27CB7C0", Offset = "0x27CB8C1", VA = "0x27CB7C0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB570", Offset = "0x1AB671")]
		private void SupportGroup()
		{
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A28")]
		[Address(RVA = "0x27CB810", Offset = "0x27CB911", VA = "0x27CB810")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB5B0", Offset = "0x1AB6B1")]
		private void ASThread()
		{
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x0001D6B8 File Offset: 0x0001B8B8
		[Token(Token = "0x6004A29")]
		[Address(RVA = "0x27CB860", Offset = "0x27CB961", VA = "0x27CB860", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x06005974 RID: 22900 RVA: 0x0001D6D0 File Offset: 0x0001B8D0
		[Token(Token = "0x6004A2A")]
		[Address(RVA = "0x27CB920", Offset = "0x27CBA21", VA = "0x27CB920")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x06005975 RID: 22901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2B")]
		[Address(RVA = "0x27CBB60", Offset = "0x27CBC61", VA = "0x27CBB60")]
		public RotationLimitAngle()
		{
		}

		// Token: 0x0400B8A4 RID: 47268
		[Token(Token = "0x4008A3A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17B9A0", Offset = "0x17BAA1")]
		public float limit;

		// Token: 0x0400B8A5 RID: 47269
		[Token(Token = "0x4008A3B")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17B9C0", Offset = "0x17BAC1")]
		public float twistLimit;
	}
}
