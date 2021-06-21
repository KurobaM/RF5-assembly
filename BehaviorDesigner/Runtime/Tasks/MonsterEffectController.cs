using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012C6 RID: 4806
	[Token(Token = "0x2000C93")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14A630", Offset = "0x14A731")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14A630", Offset = "0x14A731")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14A630", Offset = "0x14A731")]
	public class MonsterEffectController : Action
	{
		// Token: 0x060071E2 RID: 29154 RVA: 0x00027210 File Offset: 0x00025410
		[Token(Token = "0x6005E96")]
		[Address(RVA = "0x2214800", Offset = "0x2214901", VA = "0x2214800", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060071E3 RID: 29155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E97")]
		[Address(RVA = "0x2214870", Offset = "0x2214971", VA = "0x2214870", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E98")]
		[Address(RVA = "0x2214880", Offset = "0x2214981", VA = "0x2214880")]
		public MonsterEffectController()
		{
		}

		// Token: 0x0401B52A RID: 111914
		[Token(Token = "0x4017F53")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181BE0", Offset = "0x181CE1")]
		public SharedEnemyBehaviorController SharedEnemyBehaviorController;

		// Token: 0x0401B52B RID: 111915
		[Token(Token = "0x4017F54")]
		[FieldOffset(Offset = "0x58")]
		public SharedString EffectName;

		// Token: 0x0401B52C RID: 111916
		[Token(Token = "0x4017F55")]
		[FieldOffset(Offset = "0x60")]
		public SharedBool IsLoop;

		// Token: 0x0401B52D RID: 111917
		[Token(Token = "0x4017F56")]
		[FieldOffset(Offset = "0x68")]
		public SharedBool IsCreate;
	}
}
