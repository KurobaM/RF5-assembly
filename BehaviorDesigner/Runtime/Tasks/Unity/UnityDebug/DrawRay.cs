using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityDebug
{
	// Token: 0x02001454 RID: 5204
	[Token(Token = "0x2000E1A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153AD0", Offset = "0x153BD1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153AD0", Offset = "0x153BD1")]
	public class DrawRay : Action
	{
		// Token: 0x060077A0 RID: 30624 RVA: 0x000299E8 File Offset: 0x00027BE8
		[Token(Token = "0x6006454")]
		[Address(RVA = "0x28E4430", Offset = "0x28E4531", VA = "0x28E4430", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006455")]
		[Address(RVA = "0x28E4550", Offset = "0x28E4651", VA = "0x28E4550", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006456")]
		[Address(RVA = "0x28E4610", Offset = "0x28E4711", VA = "0x28E4610")]
		public DrawRay()
		{
		}

		// Token: 0x0401BA62 RID: 113250
		[Token(Token = "0x4018460")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FEA0", Offset = "0x18FFA1")]
		public SharedVector3 start;

		// Token: 0x0401BA63 RID: 113251
		[Token(Token = "0x4018461")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FEE0", Offset = "0x18FFE1")]
		public SharedVector3 direction;

		// Token: 0x0401BA64 RID: 113252
		[Token(Token = "0x4018462")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FF20", Offset = "0x190021")]
		public SharedColor color;
	}
}
