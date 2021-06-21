using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x02001301 RID: 4865
	[Token(Token = "0x2000CCE")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14BE00", Offset = "0x14BF01")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14BE00", Offset = "0x14BF01")]
	public class Angle : Action
	{
		// Token: 0x06007314 RID: 29460 RVA: 0x00027AC8 File Offset: 0x00025CC8
		[Token(Token = "0x6005FC8")]
		[Address(RVA = "0x2449410", Offset = "0x2449511", VA = "0x2449410", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007315 RID: 29461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC9")]
		[Address(RVA = "0x2449520", Offset = "0x2449621", VA = "0x2449520", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007316 RID: 29462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCA")]
		[Address(RVA = "0x24495E0", Offset = "0x24496E1", VA = "0x24495E0")]
		public Angle()
		{
		}

		// Token: 0x0401B5FF RID: 112127
		[Token(Token = "0x4018028")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183B00", Offset = "0x183C01")]
		public SharedVector3 firstVector3;

		// Token: 0x0401B600 RID: 112128
		[Token(Token = "0x4018029")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183B40", Offset = "0x183C41")]
		public SharedVector3 secondVector3;

		// Token: 0x0401B601 RID: 112129
		[Token(Token = "0x401802A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183B80", Offset = "0x183C81")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x183B80", Offset = "0x183C81")]
		public SharedFloat storeResult;
	}
}
