using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012CD RID: 4813
	[Token(Token = "0x2000C9A")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14A940", Offset = "0x14AA41")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14A940", Offset = "0x14AA41")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14A940", Offset = "0x14AA41")]
	public class UpdateMoveSpeedParameter : Action
	{
		// Token: 0x060071FE RID: 29182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB2")]
		[Address(RVA = "0x244B590", Offset = "0x244B691", VA = "0x244B590", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060071FF RID: 29183 RVA: 0x000272B8 File Offset: 0x000254B8
		[Token(Token = "0x6005EB3")]
		[Address(RVA = "0x244B6C0", Offset = "0x244B7C1", VA = "0x244B6C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007200 RID: 29184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB4")]
		[Address(RVA = "0x244B980", Offset = "0x244BA81", VA = "0x244B980", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x06007201 RID: 29185 RVA: 0x000272D0 File Offset: 0x000254D0
		[Token(Token = "0x6005EB5")]
		[Address(RVA = "0x244B8E0", Offset = "0x244B9E1", VA = "0x244B8E0")]
		public float EaseOutExpo(float s, float e, float t)
		{
			return 0f;
		}

		// Token: 0x06007202 RID: 29186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB6")]
		[Address(RVA = "0x244BA30", Offset = "0x244BB31", VA = "0x244BA30", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007203 RID: 29187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB7")]
		[Address(RVA = "0x244BA40", Offset = "0x244BB41", VA = "0x244BA40")]
		public UpdateMoveSpeedParameter()
		{
		}

		// Token: 0x0401B54B RID: 111947
		[Token(Token = "0x4017F74")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181F20", Offset = "0x182021")]
		public SharedFloat MaxMoveSpeed;

		// Token: 0x0401B54C RID: 111948
		[Token(Token = "0x4017F75")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181F60", Offset = "0x182061")]
		public SharedFloat MinMoveSpeed;

		// Token: 0x0401B54D RID: 111949
		[Token(Token = "0x4017F76")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181FA0", Offset = "0x1820A1")]
		public SharedFloat EasingTime;

		// Token: 0x0401B54E RID: 111950
		[Token(Token = "0x4017F77")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181FE0", Offset = "0x1820E1")]
		public SharedBool IsUpdateCall;

		// Token: 0x0401B54F RID: 111951
		[Token(Token = "0x4017F78")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182020", Offset = "0x182121")]
		public SharedFloat ReturnMoveSpeed;

		// Token: 0x0401B550 RID: 111952
		[Token(Token = "0x4017F79")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182060", Offset = "0x182161")]
		public SharedVector3 ReturnTargetPosition;

		// Token: 0x0401B551 RID: 111953
		[Token(Token = "0x4017F7A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1820A0", Offset = "0x1821A1")]
		public SharedBool IsStartMove;

		// Token: 0x0401B552 RID: 111954
		[Token(Token = "0x4017F7B")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1820E0", Offset = "0x1821E1")]
		public SharedBool IsEndMove;

		// Token: 0x0401B553 RID: 111955
		[Token(Token = "0x4017F7C")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 MoveDirection;

		// Token: 0x0401B554 RID: 111956
		[Token(Token = "0x4017F7D")]
		[FieldOffset(Offset = "0x9C")]
		private float T;
	}
}
