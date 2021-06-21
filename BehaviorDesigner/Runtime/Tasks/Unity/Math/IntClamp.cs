using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x02001414 RID: 5140
	[Token(Token = "0x2000DDC")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152390", Offset = "0x152491")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152390", Offset = "0x152491")]
	public class IntClamp : Action
	{
		// Token: 0x060076D5 RID: 30421 RVA: 0x00029418 File Offset: 0x00027618
		[Token(Token = "0x6006389")]
		[Address(RVA = "0x221D870", Offset = "0x221D971", VA = "0x221D870", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076D6 RID: 30422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638A")]
		[Address(RVA = "0x221D960", Offset = "0x221DA61", VA = "0x221D960", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638B")]
		[Address(RVA = "0x221DB00", Offset = "0x221DC01", VA = "0x221DB00")]
		public IntClamp()
		{
		}

		// Token: 0x0401B9AB RID: 113067
		[Token(Token = "0x40183B8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DC20", Offset = "0x18DD21")]
		public SharedInt intVariable;

		// Token: 0x0401B9AC RID: 113068
		[Token(Token = "0x40183B9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DC60", Offset = "0x18DD61")]
		public SharedInt minValue;

		// Token: 0x0401B9AD RID: 113069
		[Token(Token = "0x40183BA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DCA0", Offset = "0x18DDA1")]
		public SharedInt maxValue;
	}
}
