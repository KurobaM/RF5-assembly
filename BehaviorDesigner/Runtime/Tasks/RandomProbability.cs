using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012F4 RID: 4852
	[Token(Token = "0x2000CC1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B900", Offset = "0x14BA01")]
	public class RandomProbability : Conditional
	{
		// Token: 0x060072D4 RID: 29396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F88")]
		[Address(RVA = "0x2218430", Offset = "0x2218531", VA = "0x2218430", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x060072D5 RID: 29397 RVA: 0x000278B8 File Offset: 0x00025AB8
		[Token(Token = "0x6005F89")]
		[Address(RVA = "0x22184C0", Offset = "0x22185C1", VA = "0x22184C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072D6 RID: 29398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8A")]
		[Address(RVA = "0x2218540", Offset = "0x2218641", VA = "0x2218540", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060072D7 RID: 29399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8B")]
		[Address(RVA = "0x2218710", Offset = "0x2218811", VA = "0x2218710")]
		public RandomProbability()
		{
		}

		// Token: 0x0401B5DE RID: 112094
		[Token(Token = "0x4018007")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183620", Offset = "0x183721")]
		public SharedFloat successProbability;

		// Token: 0x0401B5DF RID: 112095
		[Token(Token = "0x4018008")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183660", Offset = "0x183761")]
		public SharedInt seed;

		// Token: 0x0401B5E0 RID: 112096
		[Token(Token = "0x4018009")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1836A0", Offset = "0x1837A1")]
		public SharedBool useSeed;
	}
}
