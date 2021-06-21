using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012D1 RID: 4817
	[Token(Token = "0x2000C9E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14AAD0", Offset = "0x14ABD1")]
	public class PartnerUpdateMovement : Action
	{
		// Token: 0x0600720D RID: 29197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC1")]
		[Address(RVA = "0x2217B40", Offset = "0x2217C41", VA = "0x2217B40", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x0600720E RID: 29198 RVA: 0x00027330 File Offset: 0x00025530
		[Token(Token = "0x6005EC2")]
		[Address(RVA = "0x2217C90", Offset = "0x2217D91", VA = "0x2217C90", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600720F RID: 29199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC3")]
		[Address(RVA = "0x2217EE0", Offset = "0x2217FE1", VA = "0x2217EE0")]
		public PartnerUpdateMovement()
		{
		}

		// Token: 0x0401B55D RID: 111965
		[Token(Token = "0x4017F86")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1821E0", Offset = "0x1822E1")]
		public SharedPartnerMovementOrderType SharedPartnerMovementOrderType;

		// Token: 0x0401B55E RID: 111966
		[Token(Token = "0x4017F87")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182220", Offset = "0x182321")]
		public SharedMovementBehaviorType SharedMovementBehaviorType;

		// Token: 0x0401B55F RID: 111967
		[Token(Token = "0x4017F88")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182260", Offset = "0x182361")]
		public SharedVector3 MovePosition;

		// Token: 0x0401B560 RID: 111968
		[Token(Token = "0x4017F89")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1822A0", Offset = "0x1823A1")]
		public SharedFloat MoveSpeed;

		// Token: 0x0401B561 RID: 111969
		[Token(Token = "0x4017F8A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1822E0", Offset = "0x1823E1")]
		public SharedFloat IntervalTime;

		// Token: 0x0401B562 RID: 111970
		[Token(Token = "0x4017F8B")]
		[FieldOffset(Offset = "0x78")]
		private PartnerMovementController PartnerMovementController;

		// Token: 0x0401B563 RID: 111971
		[Token(Token = "0x4017F8C")]
		[FieldOffset(Offset = "0x80")]
		private AIInput AIInput;
	}
}
