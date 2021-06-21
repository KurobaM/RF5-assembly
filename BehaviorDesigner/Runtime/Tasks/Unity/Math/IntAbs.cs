using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x02001413 RID: 5139
	[Token(Token = "0x2000DDB")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152330", Offset = "0x152431")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152330", Offset = "0x152431")]
	public class IntAbs : Action
	{
		// Token: 0x060076D2 RID: 30418 RVA: 0x00029400 File Offset: 0x00027600
		[Token(Token = "0x6006386")]
		[Address(RVA = "0x221D700", Offset = "0x221D801", VA = "0x221D700", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076D3 RID: 30419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006387")]
		[Address(RVA = "0x221D7B0", Offset = "0x221D8B1", VA = "0x221D7B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076D4 RID: 30420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006388")]
		[Address(RVA = "0x221D860", Offset = "0x221D961", VA = "0x221D860")]
		public IntAbs()
		{
		}

		// Token: 0x0401B9AA RID: 113066
		[Token(Token = "0x40183B7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DBE0", Offset = "0x18DCE1")]
		public SharedInt intVariable;
	}
}
