using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityQuaternion
{
	// Token: 0x020013C0 RID: 5056
	[Token(Token = "0x2000D8B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150530", Offset = "0x150631")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150530", Offset = "0x150631")]
	public class Angle : Action
	{
		// Token: 0x060075B6 RID: 30134 RVA: 0x00028C80 File Offset: 0x00026E80
		[Token(Token = "0x600626A")]
		[Address(RVA = "0x298E2A0", Offset = "0x298E3A1", VA = "0x298E2A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075B7 RID: 30135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600626B")]
		[Address(RVA = "0x298E3C0", Offset = "0x298E4C1", VA = "0x298E3C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075B8 RID: 30136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600626C")]
		[Address(RVA = "0x298E470", Offset = "0x298E571", VA = "0x298E470")]
		public Angle()
		{
		}

		// Token: 0x0401B877 RID: 112759
		[Token(Token = "0x4018298")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A850", Offset = "0x18A951")]
		public SharedQuaternion firstRotation;

		// Token: 0x0401B878 RID: 112760
		[Token(Token = "0x4018299")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A890", Offset = "0x18A991")]
		public SharedQuaternion secondRotation;

		// Token: 0x0401B879 RID: 112761
		[Token(Token = "0x401829A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A8D0", Offset = "0x18A9D1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18A8D0", Offset = "0x18A9D1")]
		public SharedFloat storeResult;
	}
}
