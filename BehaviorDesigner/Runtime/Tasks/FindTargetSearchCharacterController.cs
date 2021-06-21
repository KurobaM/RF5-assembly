using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012D2 RID: 4818
	[Token(Token = "0x2000C9F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14AB10", Offset = "0x14AC11")]
	public class FindTargetSearchCharacterController : Conditional
	{
		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06007210 RID: 29200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B33")]
		private SearchCharacterController SearchCharacterController
		{
			[Token(Token = "0x6005EC4")]
			[Address(RVA = "0x2210FB0", Offset = "0x22110B1", VA = "0x2210FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007211 RID: 29201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC5")]
		[Address(RVA = "0x2210FD0", Offset = "0x22110D1", VA = "0x2210FD0", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x06007212 RID: 29202 RVA: 0x00027348 File Offset: 0x00025548
		[Token(Token = "0x6005EC6")]
		[Address(RVA = "0x2211040", Offset = "0x2211141", VA = "0x2211040", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007213 RID: 29203 RVA: 0x00027360 File Offset: 0x00025560
		[Token(Token = "0x6005EC7")]
		[Address(RVA = "0x2211340", Offset = "0x2211441", VA = "0x2211340")]
		public int GetSearchCharacterType()
		{
			return 0;
		}

		// Token: 0x06007214 RID: 29204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC8")]
		[Address(RVA = "0x22113E0", Offset = "0x22114E1", VA = "0x22113E0")]
		public FindTargetSearchCharacterController()
		{
		}

		// Token: 0x0401B564 RID: 111972
		[Token(Token = "0x4017F8D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182320", Offset = "0x182421")]
		public SharedInt SearchType;

		// Token: 0x0401B565 RID: 111973
		[Token(Token = "0x4017F8E")]
		[FieldOffset(Offset = "0x58")]
		public SharedBool UseMaxRange;

		// Token: 0x0401B566 RID: 111974
		[Token(Token = "0x4017F8F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182360", Offset = "0x182461")]
		public SharedGameObject ReturnTarget;

		// Token: 0x0401B567 RID: 111975
		[Token(Token = "0x4017F90")]
		[FieldOffset(Offset = "0x68")]
		private AIInput AIInput;
	}
}
