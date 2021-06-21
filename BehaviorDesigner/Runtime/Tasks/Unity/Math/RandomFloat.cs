using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x0200141E RID: 5150
	[Token(Token = "0x2000DE4")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152690", Offset = "0x152791")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152690", Offset = "0x152791")]
	public class RandomFloat : Action
	{
		// Token: 0x060076EC RID: 30444 RVA: 0x000294D8 File Offset: 0x000276D8
		[Token(Token = "0x60063A0")]
		[Address(RVA = "0x221EBE0", Offset = "0x221ECE1", VA = "0x221EBE0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063A1")]
		[Address(RVA = "0x221ECB0", Offset = "0x221EDB1", VA = "0x221ECB0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076EE RID: 30446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063A2")]
		[Address(RVA = "0x221EDC0", Offset = "0x221EEC1", VA = "0x221EDC0")]
		public RandomFloat()
		{
		}

		// Token: 0x0401B9CF RID: 113103
		[Token(Token = "0x40183CD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E190", Offset = "0x18E291")]
		public SharedFloat min;

		// Token: 0x0401B9D0 RID: 113104
		[Token(Token = "0x40183CE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E1D0", Offset = "0x18E2D1")]
		public SharedFloat max;

		// Token: 0x0401B9D1 RID: 113105
		[Token(Token = "0x40183CF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E210", Offset = "0x18E311")]
		public bool inclusive;

		// Token: 0x0401B9D2 RID: 113106
		[Token(Token = "0x40183D0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E250", Offset = "0x18E351")]
		public SharedFloat storeResult;
	}
}
