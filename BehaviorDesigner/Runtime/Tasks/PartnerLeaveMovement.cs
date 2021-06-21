using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012D0 RID: 4816
	[Token(Token = "0x2000C9D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14AA90", Offset = "0x14AB91")]
	public class PartnerLeaveMovement : Action
	{
		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06007208 RID: 29192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B32")]
		private PartnerMovementController PartnerMovementController
		{
			[Token(Token = "0x6005EBC")]
			[Address(RVA = "0x22176A0", Offset = "0x22177A1", VA = "0x22176A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007209 RID: 29193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBD")]
		[Address(RVA = "0x2217790", Offset = "0x2217891", VA = "0x2217790", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x0600720A RID: 29194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBE")]
		[Address(RVA = "0x2217860", Offset = "0x2217961", VA = "0x2217860", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600720B RID: 29195 RVA: 0x00027318 File Offset: 0x00025518
		[Token(Token = "0x6005EBF")]
		[Address(RVA = "0x22179A0", Offset = "0x2217AA1", VA = "0x22179A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600720C RID: 29196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC0")]
		[Address(RVA = "0x2217B30", Offset = "0x2217C31", VA = "0x2217B30")]
		public PartnerLeaveMovement()
		{
		}

		// Token: 0x0401B559 RID: 111961
		[Token(Token = "0x4017F82")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182120", Offset = "0x182221")]
		public SharedMovementBehaviorType SharedMovementBehaviorType;

		// Token: 0x0401B55A RID: 111962
		[Token(Token = "0x4017F83")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182160", Offset = "0x182261")]
		public SharedVector3 MovePosition;

		// Token: 0x0401B55B RID: 111963
		[Token(Token = "0x4017F84")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1821A0", Offset = "0x1822A1")]
		public SharedFloat MoveSpeed;

		// Token: 0x0401B55C RID: 111964
		[Token(Token = "0x4017F85")]
		[FieldOffset(Offset = "0x68")]
		private AIInput AIInput;
	}
}
