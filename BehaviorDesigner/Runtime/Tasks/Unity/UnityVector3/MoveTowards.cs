using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x0200130D RID: 4877
	[Token(Token = "0x2000CDA")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C280", Offset = "0x14C381")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C280", Offset = "0x14C381")]
	public class MoveTowards : Action
	{
		// Token: 0x06007338 RID: 29496 RVA: 0x00027BE8 File Offset: 0x00025DE8
		[Token(Token = "0x6005FEC")]
		[Address(RVA = "0x244A6E0", Offset = "0x244A7E1", VA = "0x244A6E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007339 RID: 29497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FED")]
		[Address(RVA = "0x244A820", Offset = "0x244A921", VA = "0x244A820", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600733A RID: 29498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FEE")]
		[Address(RVA = "0x244A900", Offset = "0x244AA01", VA = "0x244A900")]
		public MoveTowards()
		{
		}

		// Token: 0x0401B61C RID: 112156
		[Token(Token = "0x4018045")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184320", Offset = "0x184421")]
		public SharedVector3 currentPosition;

		// Token: 0x0401B61D RID: 112157
		[Token(Token = "0x4018046")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184360", Offset = "0x184461")]
		public SharedVector3 targetPosition;

		// Token: 0x0401B61E RID: 112158
		[Token(Token = "0x4018047")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1843A0", Offset = "0x1844A1")]
		public SharedFloat speed;

		// Token: 0x0401B61F RID: 112159
		[Token(Token = "0x4018048")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1843E0", Offset = "0x1844E1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1843E0", Offset = "0x1844E1")]
		public SharedVector3 storeResult;
	}
}
