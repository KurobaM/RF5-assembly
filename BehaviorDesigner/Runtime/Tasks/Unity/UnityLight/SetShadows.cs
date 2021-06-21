using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x02001432 RID: 5170
	[Token(Token = "0x2000DF8")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152E10", Offset = "0x152F11")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152E10", Offset = "0x152F11")]
	public class SetShadows : Action
	{
		// Token: 0x06007737 RID: 30519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063EB")]
		[Address(RVA = "0x28E8FD0", Offset = "0x28E90D1", VA = "0x28E8FD0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007738 RID: 30520 RVA: 0x000296B8 File Offset: 0x000278B8
		[Token(Token = "0x60063EC")]
		[Address(RVA = "0x28E90D0", Offset = "0x28E91D1", VA = "0x28E90D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063ED")]
		[Address(RVA = "0x28E91B0", Offset = "0x28E92B1", VA = "0x28E91B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600773A RID: 30522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063EE")]
		[Address(RVA = "0x28E91C0", Offset = "0x28E92C1", VA = "0x28E91C0")]
		public SetShadows()
		{
		}

		// Token: 0x0401BA19 RID: 113177
		[Token(Token = "0x4018417")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18ED00", Offset = "0x18EE01")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA1A RID: 113178
		[Token(Token = "0x4018418")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18ED40", Offset = "0x18EE41")]
		public LightShadows shadows;

		// Token: 0x0401BA1B RID: 113179
		[Token(Token = "0x4018419")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401BA1C RID: 113180
		[Token(Token = "0x401841A")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
