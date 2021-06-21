using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CD9 RID: 3289
	[Token(Token = "0x2000874")]
	public class TouchWalls : MonoBehaviour
	{
		// Token: 0x0600543A RID: 21562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004635")]
		[Address(RVA = "0x2863A50", Offset = "0x2863B51", VA = "0x2863A50")]
		private void Start()
		{
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004636")]
		[Address(RVA = "0x2863DE0", Offset = "0x2863EE1", VA = "0x2863DE0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600543C RID: 21564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004637")]
		[Address(RVA = "0x2864580", Offset = "0x2864681", VA = "0x2864580")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600543D RID: 21565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004638")]
		[Address(RVA = "0x2864800", Offset = "0x2864901", VA = "0x2864800")]
		public TouchWalls()
		{
		}

		// Token: 0x0400B35F RID: 45919
		[Token(Token = "0x40086B6")]
		[FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		// Token: 0x0400B360 RID: 45920
		[Token(Token = "0x40086B7")]
		[FieldOffset(Offset = "0x20")]
		public TouchWalls.EffectorLink[] effectorLinks;

		// Token: 0x02000CDA RID: 3290
		[Token(Token = "0x20013DE")]
		[Serializable]
		public class EffectorLink
		{
			// Token: 0x0600543E RID: 21566 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078CF")]
			[Address(RVA = "0x2863AD0", Offset = "0x2863BD1", VA = "0x2863AD0")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			// Token: 0x0600543F RID: 21567 RVA: 0x0001BC90 File Offset: 0x00019E90
			[Token(Token = "0x60078D0")]
			[Address(RVA = "0x2864810", Offset = "0x2864911", VA = "0x2864810")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			// Token: 0x06005440 RID: 21568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078D1")]
			[Address(RVA = "0x2863E50", Offset = "0x2863F51", VA = "0x2863E50")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			// Token: 0x06005441 RID: 21569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078D2")]
			[Address(RVA = "0x2864900", Offset = "0x2864A01", VA = "0x2864900")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			// Token: 0x06005442 RID: 21570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078D3")]
			[Address(RVA = "0x2864AA0", Offset = "0x2864BA1", VA = "0x2864AA0")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			// Token: 0x06005443 RID: 21571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078D4")]
			[Address(RVA = "0x2864B40", Offset = "0x2864C41", VA = "0x2864B40")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			// Token: 0x06005444 RID: 21572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078D5")]
			[Address(RVA = "0x2864BE0", Offset = "0x2864CE1", VA = "0x2864BE0")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			// Token: 0x06005445 RID: 21573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078D6")]
			[Address(RVA = "0x2864650", Offset = "0x2864751", VA = "0x2864650")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			// Token: 0x06005446 RID: 21574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078D7")]
			[Address(RVA = "0x2864C80", Offset = "0x2864D81", VA = "0x2864C80")]
			public EffectorLink()
			{
			}

			// Token: 0x0400B361 RID: 45921
			[Token(Token = "0x401B8ED")]
			[FieldOffset(Offset = "0x10")]
			public bool enabled;

			// Token: 0x0400B362 RID: 45922
			[Token(Token = "0x401B8EE")]
			[FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			// Token: 0x0400B363 RID: 45923
			[Token(Token = "0x401B8EF")]
			[FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			// Token: 0x0400B364 RID: 45924
			[Token(Token = "0x401B8F0")]
			[FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			// Token: 0x0400B365 RID: 45925
			[Token(Token = "0x401B8F1")]
			[FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			// Token: 0x0400B366 RID: 45926
			[Token(Token = "0x401B8F2")]
			[FieldOffset(Offset = "0x2C")]
			public float minDistance;

			// Token: 0x0400B367 RID: 45927
			[Token(Token = "0x401B8F3")]
			[FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			// Token: 0x0400B368 RID: 45928
			[Token(Token = "0x401B8F4")]
			[FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			// Token: 0x0400B369 RID: 45929
			[Token(Token = "0x401B8F5")]
			[FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			// Token: 0x0400B36A RID: 45930
			[Token(Token = "0x401B8F6")]
			[FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			// Token: 0x0400B36B RID: 45931
			[Token(Token = "0x401B8F7")]
			[FieldOffset(Offset = "0x40")]
			public bool sliding;

			// Token: 0x0400B36C RID: 45932
			[Token(Token = "0x401B8F8")]
			[FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			// Token: 0x0400B36D RID: 45933
			[Token(Token = "0x401B8F9")]
			[FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			// Token: 0x0400B36E RID: 45934
			[Token(Token = "0x401B8FA")]
			[FieldOffset(Offset = "0x54")]
			private bool inTouch;

			// Token: 0x0400B36F RID: 45935
			[Token(Token = "0x401B8FB")]
			[FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			// Token: 0x0400B370 RID: 45936
			[Token(Token = "0x401B8FC")]
			[FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			// Token: 0x0400B371 RID: 45937
			[Token(Token = "0x401B8FD")]
			[FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			// Token: 0x0400B372 RID: 45938
			[Token(Token = "0x401B8FE")]
			[FieldOffset(Offset = "0xA0")]
			private bool initiated;

			// Token: 0x0400B373 RID: 45939
			[Token(Token = "0x401B8FF")]
			[FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			// Token: 0x0400B374 RID: 45940
			[Token(Token = "0x401B900")]
			[FieldOffset(Offset = "0xA8")]
			private float speedF;
		}
	}
}
