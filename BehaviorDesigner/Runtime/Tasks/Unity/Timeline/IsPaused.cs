using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Timeline
{
	// Token: 0x02001345 RID: 4933
	[Token(Token = "0x2000D10")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D6C0", Offset = "0x14D7C1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D6C0", Offset = "0x14D7C1")]
	public class IsPaused : Conditional
	{
		// Token: 0x060073F9 RID: 29689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AD")]
		[Address(RVA = "0x28D1690", Offset = "0x28D1791", VA = "0x28D1690", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073FA RID: 29690 RVA: 0x000280F8 File Offset: 0x000262F8
		[Token(Token = "0x60060AE")]
		[Address(RVA = "0x28D1790", Offset = "0x28D1891", VA = "0x28D1790", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073FB RID: 29691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AF")]
		[Address(RVA = "0x28D1870", Offset = "0x28D1971", VA = "0x28D1870", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073FC RID: 29692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B0")]
		[Address(RVA = "0x28D1880", Offset = "0x28D1981", VA = "0x28D1880")]
		public IsPaused()
		{
		}

		// Token: 0x0401B6ED RID: 112365
		[Token(Token = "0x401810E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1867F0", Offset = "0x1868F1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6EE RID: 112366
		[Token(Token = "0x401810F")]
		[FieldOffset(Offset = "0x58")]
		private PlayableDirector playableDirector;

		// Token: 0x0401B6EF RID: 112367
		[Token(Token = "0x4018110")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
