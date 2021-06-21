using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x0200142C RID: 5164
	[Token(Token = "0x2000DF2")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152BD0", Offset = "0x152CD1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152BD0", Offset = "0x152CD1")]
	public class SetCookieSize : Action
	{
		// Token: 0x0600771F RID: 30495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D3")]
		[Address(RVA = "0x28E8200", Offset = "0x28E8301", VA = "0x28E8200", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x00029628 File Offset: 0x00027828
		[Token(Token = "0x60063D4")]
		[Address(RVA = "0x28E8300", Offset = "0x28E8401", VA = "0x28E8300", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007721 RID: 30497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D5")]
		[Address(RVA = "0x28E83F0", Offset = "0x28E84F1", VA = "0x28E83F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007722 RID: 30498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D6")]
		[Address(RVA = "0x28E8440", Offset = "0x28E8541", VA = "0x28E8440")]
		public SetCookieSize()
		{
		}

		// Token: 0x0401BA01 RID: 113153
		[Token(Token = "0x40183FF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EA00", Offset = "0x18EB01")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA02 RID: 113154
		[Token(Token = "0x4018400")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EA40", Offset = "0x18EB41")]
		public SharedFloat cookieSize;

		// Token: 0x0401BA03 RID: 113155
		[Token(Token = "0x4018401")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401BA04 RID: 113156
		[Token(Token = "0x4018402")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
