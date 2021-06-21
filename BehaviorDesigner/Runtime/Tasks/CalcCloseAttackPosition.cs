using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012C3 RID: 4803
	[Token(Token = "0x2000C90")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14A500", Offset = "0x14A601")]
	public class CalcCloseAttackPosition : Action
	{
		// Token: 0x060071D4 RID: 29140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E88")]
		[Address(RVA = "0x220F640", Offset = "0x220F741", VA = "0x220F640", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x060071D5 RID: 29141 RVA: 0x000271C8 File Offset: 0x000253C8
		[Token(Token = "0x6005E89")]
		[Address(RVA = "0x220F710", Offset = "0x220F811", VA = "0x220F710", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060071D6 RID: 29142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E8A")]
		[Address(RVA = "0x220F920", Offset = "0x220FA21", VA = "0x220F920", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060071D7 RID: 29143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E8B")]
		[Address(RVA = "0x220F970", Offset = "0x220FA71", VA = "0x220F970")]
		public CalcCloseAttackPosition()
		{
		}

		// Token: 0x0401B51E RID: 111902
		[Token(Token = "0x4017F47")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181A60", Offset = "0x181B61")]
		public SharedFloat CloseRange;

		// Token: 0x0401B51F RID: 111903
		[Token(Token = "0x4017F48")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181AA0", Offset = "0x181BA1")]
		public SharedGameObject Target;

		// Token: 0x0401B520 RID: 111904
		[Token(Token = "0x4017F49")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181AE0", Offset = "0x181BE1")]
		public SharedVector3 ReturnCloseAttackPosition;

		// Token: 0x0401B521 RID: 111905
		[Token(Token = "0x4017F4A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string CloseRangeKeyName;

		// Token: 0x0401B522 RID: 111906
		[Token(Token = "0x4017F4B")]
		[FieldOffset(Offset = "0x68")]
		private AIInput AIInput;
	}
}
