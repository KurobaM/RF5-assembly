using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001329 RID: 4905
	[Token(Token = "0x2000CF4")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CC40", Offset = "0x14CD41")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CC40", Offset = "0x14CD41")]
	public class GetChildCount : Action
	{
		// Token: 0x06007389 RID: 29577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600603D")]
		[Address(RVA = "0x299B200", Offset = "0x299B301", VA = "0x299B200", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600738A RID: 29578 RVA: 0x00027E58 File Offset: 0x00026058
		[Token(Token = "0x600603E")]
		[Address(RVA = "0x299B300", Offset = "0x299B401", VA = "0x299B300", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600738B RID: 29579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600603F")]
		[Address(RVA = "0x299B400", Offset = "0x299B501", VA = "0x299B400", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006040")]
		[Address(RVA = "0x299B450", Offset = "0x299B551", VA = "0x299B450")]
		public GetChildCount()
		{
		}

		// Token: 0x0401B677 RID: 112247
		[Token(Token = "0x4018098")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1857B0", Offset = "0x1858B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B678 RID: 112248
		[Token(Token = "0x4018099")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1857F0", Offset = "0x1858F1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1857F0", Offset = "0x1858F1")]
		public SharedInt storeValue;

		// Token: 0x0401B679 RID: 112249
		[Token(Token = "0x401809A")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B67A RID: 112250
		[Token(Token = "0x401809B")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
