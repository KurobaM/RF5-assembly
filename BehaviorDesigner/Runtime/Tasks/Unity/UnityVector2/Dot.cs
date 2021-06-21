using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x02001317 RID: 4887
	[Token(Token = "0x2000CE3")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C5E0", Offset = "0x14C6E1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C5E0", Offset = "0x14C6E1")]
	public class Dot : Action
	{
		// Token: 0x06007353 RID: 29523 RVA: 0x00027CC0 File Offset: 0x00025EC0
		[Token(Token = "0x6006007")]
		[Address(RVA = "0x299FE00", Offset = "0x299FF01", VA = "0x299FE00", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007354 RID: 29524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006008")]
		[Address(RVA = "0x299FEF0", Offset = "0x299FFF1", VA = "0x299FEF0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007355 RID: 29525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006009")]
		[Address(RVA = "0x299FFB0", Offset = "0x29A00B1", VA = "0x299FFB0")]
		public Dot()
		{
		}

		// Token: 0x0401B63E RID: 112190
		[Token(Token = "0x4018063")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184B00", Offset = "0x184C01")]
		public SharedVector2 leftHandSide;

		// Token: 0x0401B63F RID: 112191
		[Token(Token = "0x4018064")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184B40", Offset = "0x184C41")]
		public SharedVector2 rightHandSide;

		// Token: 0x0401B640 RID: 112192
		[Token(Token = "0x4018065")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184B80", Offset = "0x184C81")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184B80", Offset = "0x184C81")]
		public SharedFloat storeResult;
	}
}
