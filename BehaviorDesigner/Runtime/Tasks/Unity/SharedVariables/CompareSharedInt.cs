using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001362 RID: 4962
	[Token(Token = "0x2000D2D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E1A0", Offset = "0x14E2A1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E1A0", Offset = "0x14E2A1")]
	public class CompareSharedInt : Conditional
	{
		// Token: 0x0600745B RID: 29787 RVA: 0x000283B0 File Offset: 0x000265B0
		[Token(Token = "0x600610F")]
		[Address(RVA = "0x221FED0", Offset = "0x221FFD1", VA = "0x221FED0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600745C RID: 29788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006110")]
		[Address(RVA = "0x221FF70", Offset = "0x2220071", VA = "0x221FF70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600745D RID: 29789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006111")]
		[Address(RVA = "0x22200A0", Offset = "0x22201A1", VA = "0x22200A0")]
		public CompareSharedInt()
		{
		}

		// Token: 0x0401B73B RID: 112443
		[Token(Token = "0x401815C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187650", Offset = "0x187751")]
		public SharedInt variable;

		// Token: 0x0401B73C RID: 112444
		[Token(Token = "0x401815D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187690", Offset = "0x187791")]
		public SharedInt compareTo;
	}
}
