using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x0200141F RID: 5151
	[Token(Token = "0x2000DE5")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1526F0", Offset = "0x1527F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1526F0", Offset = "0x1527F1")]
	public class RandomInt : Action
	{
		// Token: 0x060076EF RID: 30447 RVA: 0x000294F0 File Offset: 0x000276F0
		[Token(Token = "0x60063A3")]
		[Address(RVA = "0x221EDD0", Offset = "0x221EED1", VA = "0x221EDD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076F0 RID: 30448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063A4")]
		[Address(RVA = "0x221EE90", Offset = "0x221EF91", VA = "0x221EE90", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076F1 RID: 30449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063A5")]
		[Address(RVA = "0x221EFA0", Offset = "0x221F0A1", VA = "0x221EFA0")]
		public RandomInt()
		{
		}

		// Token: 0x0401B9D3 RID: 113107
		[Token(Token = "0x40183D1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E290", Offset = "0x18E391")]
		public SharedInt min;

		// Token: 0x0401B9D4 RID: 113108
		[Token(Token = "0x40183D2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E2D0", Offset = "0x18E3D1")]
		public SharedInt max;

		// Token: 0x0401B9D5 RID: 113109
		[Token(Token = "0x40183D3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E310", Offset = "0x18E411")]
		public bool inclusive;

		// Token: 0x0401B9D6 RID: 113110
		[Token(Token = "0x40183D4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E350", Offset = "0x18E451")]
		public SharedInt storeResult;
	}
}
