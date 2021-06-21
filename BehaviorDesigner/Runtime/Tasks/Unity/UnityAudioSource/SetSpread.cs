using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x0200149B RID: 5275
	[Token(Token = "0x2000E61")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155570", Offset = "0x155671")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155570", Offset = "0x155671")]
	public class SetSpread : Action
	{
		// Token: 0x060078B7 RID: 30903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656B")]
		[Address(RVA = "0x28DE210", Offset = "0x28DE311", VA = "0x28DE210", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078B8 RID: 30904 RVA: 0x0002A0A8 File Offset: 0x000282A8
		[Token(Token = "0x600656C")]
		[Address(RVA = "0x28DE310", Offset = "0x28DE411", VA = "0x28DE310", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078B9 RID: 30905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656D")]
		[Address(RVA = "0x28DE400", Offset = "0x28DE501", VA = "0x28DE400", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078BA RID: 30906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656E")]
		[Address(RVA = "0x28DE450", Offset = "0x28DE551", VA = "0x28DE450")]
		public SetSpread()
		{
		}

		// Token: 0x0401BB6E RID: 113518
		[Token(Token = "0x401856C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192330", Offset = "0x192431")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB6F RID: 113519
		[Token(Token = "0x401856D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192370", Offset = "0x192471")]
		public SharedFloat spread;

		// Token: 0x0401BB70 RID: 113520
		[Token(Token = "0x401856E")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB71 RID: 113521
		[Token(Token = "0x401856F")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
