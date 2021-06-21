using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x0200130F RID: 4879
	[Token(Token = "0x2000CDC")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C340", Offset = "0x14C441")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C340", Offset = "0x14C441")]
	public class Normalize : Action
	{
		// Token: 0x0600733E RID: 29502 RVA: 0x00027C18 File Offset: 0x00025E18
		[Token(Token = "0x6005FF2")]
		[Address(RVA = "0x244AAD0", Offset = "0x244ABD1", VA = "0x244AAD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600733F RID: 29503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF3")]
		[Address(RVA = "0x244ABA0", Offset = "0x244ACA1", VA = "0x244ABA0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007340 RID: 29504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF4")]
		[Address(RVA = "0x244AC40", Offset = "0x244AD41", VA = "0x244AC40")]
		public Normalize()
		{
		}

		// Token: 0x0401B623 RID: 112163
		[Token(Token = "0x401804C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184500", Offset = "0x184601")]
		public SharedVector3 vector3Variable;

		// Token: 0x0401B624 RID: 112164
		[Token(Token = "0x401804D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184540", Offset = "0x184641")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184540", Offset = "0x184641")]
		public SharedVector3 storeResult;
	}
}
