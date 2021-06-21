using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityQuaternion
{
	// Token: 0x020013C4 RID: 5060
	[Token(Token = "0x2000D8F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1506B0", Offset = "0x1507B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1506B0", Offset = "0x1507B1")]
	public class FromToRotation : Action
	{
		// Token: 0x060075C2 RID: 30146 RVA: 0x00028CE0 File Offset: 0x00026EE0
		[Token(Token = "0x6006276")]
		[Address(RVA = "0x298E9E0", Offset = "0x298EAE1", VA = "0x298E9E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075C3 RID: 30147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006277")]
		[Address(RVA = "0x298EAF0", Offset = "0x298EBF1", VA = "0x298EAF0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075C4 RID: 30148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006278")]
		[Address(RVA = "0x298EBC0", Offset = "0x298ECC1", VA = "0x298EBC0")]
		public FromToRotation()
		{
		}

		// Token: 0x0401B882 RID: 112770
		[Token(Token = "0x40182A3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AB50", Offset = "0x18AC51")]
		public SharedVector3 fromDirection;

		// Token: 0x0401B883 RID: 112771
		[Token(Token = "0x40182A4")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AB90", Offset = "0x18AC91")]
		public SharedVector3 toDirection;

		// Token: 0x0401B884 RID: 112772
		[Token(Token = "0x40182A5")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18ABD0", Offset = "0x18ACD1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18ABD0", Offset = "0x18ACD1")]
		public SharedQuaternion storeResult;
	}
}
