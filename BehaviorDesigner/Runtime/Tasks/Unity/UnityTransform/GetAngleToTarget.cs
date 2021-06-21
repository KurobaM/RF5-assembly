using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001327 RID: 4903
	[Token(Token = "0x2000CF2")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CB80", Offset = "0x14CC81")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CB80", Offset = "0x14CC81")]
	public class GetAngleToTarget : Action
	{
		// Token: 0x06007381 RID: 29569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006035")]
		[Address(RVA = "0x299AAF0", Offset = "0x299ABF1", VA = "0x299AAF0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007382 RID: 29570 RVA: 0x00027E28 File Offset: 0x00026028
		[Token(Token = "0x6006036")]
		[Address(RVA = "0x299ABF0", Offset = "0x299ACF1", VA = "0x299ABF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007383 RID: 29571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006037")]
		[Address(RVA = "0x299AE70", Offset = "0x299AF71", VA = "0x299AE70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007384 RID: 29572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006038")]
		[Address(RVA = "0x299AF50", Offset = "0x299B051", VA = "0x299AF50")]
		public GetAngleToTarget()
		{
		}

		// Token: 0x0401B66B RID: 112235
		[Token(Token = "0x401808C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185590", Offset = "0x185691")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B66C RID: 112236
		[Token(Token = "0x401808D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1855D0", Offset = "0x1856D1")]
		public SharedGameObject targetObject;

		// Token: 0x0401B66D RID: 112237
		[Token(Token = "0x401808E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185610", Offset = "0x185711")]
		public SharedVector3 targetPosition;

		// Token: 0x0401B66E RID: 112238
		[Token(Token = "0x401808F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185650", Offset = "0x185751")]
		public SharedBool ignoreHeight;

		// Token: 0x0401B66F RID: 112239
		[Token(Token = "0x4018090")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185690", Offset = "0x185791")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x185690", Offset = "0x185791")]
		public SharedFloat storeValue;

		// Token: 0x0401B670 RID: 112240
		[Token(Token = "0x4018091")]
		[FieldOffset(Offset = "0x78")]
		private Transform targetTransform;

		// Token: 0x0401B671 RID: 112241
		[Token(Token = "0x4018092")]
		[FieldOffset(Offset = "0x80")]
		private GameObject prevGameObject;
	}
}
