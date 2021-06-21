using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012C1 RID: 4801
	[Token(Token = "0x2000C8E")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14A410", Offset = "0x14A511")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14A410", Offset = "0x14A511")]
	public class MonsterJump : Action
	{
		// Token: 0x060071CB RID: 29131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E7F")]
		[Address(RVA = "0x2214890", Offset = "0x2214991", VA = "0x2214890", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x060071CC RID: 29132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E80")]
		[Address(RVA = "0x2214960", Offset = "0x2214A61", VA = "0x2214960", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060071CD RID: 29133 RVA: 0x00027198 File Offset: 0x00025398
		[Token(Token = "0x6005E81")]
		[Address(RVA = "0x2214A00", Offset = "0x2214B01", VA = "0x2214A00", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060071CE RID: 29134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E82")]
		[Address(RVA = "0x2214F90", Offset = "0x2215091", VA = "0x2214F90", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060071CF RID: 29135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E83")]
		[Address(RVA = "0x2214DF0", Offset = "0x2214EF1", VA = "0x2214DF0")]
		private void UpdateGroundHeight()
		{
		}

		// Token: 0x060071D0 RID: 29136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E84")]
		[Address(RVA = "0x2214FA0", Offset = "0x22150A1", VA = "0x2214FA0")]
		public MonsterJump()
		{
		}

		// Token: 0x0401B515 RID: 111893
		[Token(Token = "0x4017F3E")]
		private const float GravityAccel = 9.8f;

		// Token: 0x0401B516 RID: 111894
		[Token(Token = "0x4017F3F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181920", Offset = "0x181A21")]
		public SharedVector3 SharedVelocity;

		// Token: 0x0401B517 RID: 111895
		[Token(Token = "0x4017F40")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 CurrentVelocity;

		// Token: 0x0401B518 RID: 111896
		[Token(Token = "0x4017F41")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 GroundPosition;

		// Token: 0x0401B519 RID: 111897
		[Token(Token = "0x4017F42")]
		[FieldOffset(Offset = "0x70")]
		private AIInput AIInput;
	}
}
