using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x0200141B RID: 5147
	[Token(Token = "0x2000DE1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152570", Offset = "0x152671")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152570", Offset = "0x152671")]
	public class Lerp : Action
	{
		// Token: 0x060076E4 RID: 30436 RVA: 0x00029490 File Offset: 0x00027690
		[Token(Token = "0x6006398")]
		[Address(RVA = "0x221E490", Offset = "0x221E591", VA = "0x221E490", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076E5 RID: 30437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006399")]
		[Address(RVA = "0x221E590", Offset = "0x221E691", VA = "0x221E590", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076E6 RID: 30438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600639A")]
		[Address(RVA = "0x221E7E0", Offset = "0x221E8E1", VA = "0x221E7E0")]
		public Lerp()
		{
		}

		// Token: 0x0401B9C6 RID: 113094
		[Token(Token = "0x40183C4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DF30", Offset = "0x18E031")]
		public SharedFloat fromValue;

		// Token: 0x0401B9C7 RID: 113095
		[Token(Token = "0x40183C5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DF70", Offset = "0x18E071")]
		public SharedFloat toValue;

		// Token: 0x0401B9C8 RID: 113096
		[Token(Token = "0x40183C6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DFB0", Offset = "0x18E0B1")]
		public SharedFloat lerpAmount;

		// Token: 0x0401B9C9 RID: 113097
		[Token(Token = "0x40183C7")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DFF0", Offset = "0x18E0F1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18DFF0", Offset = "0x18E0F1")]
		public SharedFloat storeResult;
	}
}
