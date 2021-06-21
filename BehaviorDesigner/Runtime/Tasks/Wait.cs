using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012E0 RID: 4832
	[Token(Token = "0x2000CAD")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B180", Offset = "0x14B281")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B180", Offset = "0x14B281")]
	public class Wait : Action
	{
		// Token: 0x0600723F RID: 29247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF3")]
		[Address(RVA = "0x244BFD0", Offset = "0x244C0D1", VA = "0x244BFD0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007240 RID: 29248 RVA: 0x00027498 File Offset: 0x00025698
		[Token(Token = "0x6005EF4")]
		[Address(RVA = "0x244C0A0", Offset = "0x244C1A1", VA = "0x244C0A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007241 RID: 29249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF5")]
		[Address(RVA = "0x244C0E0", Offset = "0x244C1E1", VA = "0x244C0E0", Slot = "10")]
		public override void OnPause(bool paused)
		{
		}

		// Token: 0x06007242 RID: 29250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF6")]
		[Address(RVA = "0x244C140", Offset = "0x244C241", VA = "0x244C140", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007243 RID: 29251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF7")]
		[Address(RVA = "0x244C1E0", Offset = "0x244C2E1", VA = "0x244C1E0")]
		public Wait()
		{
		}

		// Token: 0x0401B599 RID: 112025
		[Token(Token = "0x4017FC2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182EF0", Offset = "0x182FF1")]
		public SharedFloat waitTime;

		// Token: 0x0401B59A RID: 112026
		[Token(Token = "0x4017FC3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182F30", Offset = "0x183031")]
		public SharedBool randomWait;

		// Token: 0x0401B59B RID: 112027
		[Token(Token = "0x4017FC4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182F70", Offset = "0x183071")]
		public SharedFloat randomWaitMin;

		// Token: 0x0401B59C RID: 112028
		[Token(Token = "0x4017FC5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182FB0", Offset = "0x1830B1")]
		public SharedFloat randomWaitMax;

		// Token: 0x0401B59D RID: 112029
		[Token(Token = "0x4017FC6")]
		[FieldOffset(Offset = "0x70")]
		private float waitDuration;

		// Token: 0x0401B59E RID: 112030
		[Token(Token = "0x4017FC7")]
		[FieldOffset(Offset = "0x74")]
		private float startTime;

		// Token: 0x0401B59F RID: 112031
		[Token(Token = "0x4017FC8")]
		[FieldOffset(Offset = "0x78")]
		private float pauseTime;
	}
}
