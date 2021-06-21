using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRenderer
{
	// Token: 0x020013BF RID: 5055
	[Token(Token = "0x2000D8A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1504D0", Offset = "0x1505D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1504D0", Offset = "0x1505D1")]
	public class SetMaterial : Action
	{
		// Token: 0x060075B2 RID: 30130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006266")]
		[Address(RVA = "0x298F870", Offset = "0x298F971", VA = "0x298F870", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060075B3 RID: 30131 RVA: 0x00028C68 File Offset: 0x00026E68
		[Token(Token = "0x6006267")]
		[Address(RVA = "0x298F970", Offset = "0x298FA71", VA = "0x298F970", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075B4 RID: 30132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006268")]
		[Address(RVA = "0x298FA70", Offset = "0x298FB71", VA = "0x298FA70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075B5 RID: 30133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006269")]
		[Address(RVA = "0x298FAB0", Offset = "0x298FBB1", VA = "0x298FAB0")]
		public SetMaterial()
		{
		}

		// Token: 0x0401B873 RID: 112755
		[Token(Token = "0x4018294")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A7D0", Offset = "0x18A8D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B874 RID: 112756
		[Token(Token = "0x4018295")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A810", Offset = "0x18A911")]
		public SharedMaterial material;

		// Token: 0x0401B875 RID: 112757
		[Token(Token = "0x4018296")]
		[FieldOffset(Offset = "0x60")]
		private Renderer renderer;

		// Token: 0x0401B876 RID: 112758
		[Token(Token = "0x4018297")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
