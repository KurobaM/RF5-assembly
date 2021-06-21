using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CD0 RID: 3280
	[Token(Token = "0x200086D")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		// Token: 0x06005412 RID: 21522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004619")]
		[Address(RVA = "0x285F940", Offset = "0x285FA41", VA = "0x285F940")]
		private void OnGUI()
		{
		}

		// Token: 0x06005413 RID: 21523
		[Token(Token = "0x600461A")]
		protected abstract void RotatePivot();

		// Token: 0x06005414 RID: 21524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600461B")]
		[Address(RVA = "0x285FC40", Offset = "0x285FD41", VA = "0x285FC40")]
		private void Start()
		{
		}

		// Token: 0x06005415 RID: 21525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600461C")]
		[Address(RVA = "0x285FDE0", Offset = "0x285FEE1", VA = "0x285FDE0")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		// Token: 0x06005416 RID: 21526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600461D")]
		[Address(RVA = "0x285FF60", Offset = "0x2860061", VA = "0x285FF60")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		// Token: 0x06005417 RID: 21527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600461E")]
		[Address(RVA = "0x2860040", Offset = "0x2860141", VA = "0x2860040")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		// Token: 0x06005418 RID: 21528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600461F")]
		[Address(RVA = "0x2860170", Offset = "0x2860271", VA = "0x2860170")]
		private void LateUpdate()
		{
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06005419 RID: 21529 RVA: 0x0001BC48 File Offset: 0x00019E48
		[Token(Token = "0x1700089A")]
		private bool holding
		{
			[Token(Token = "0x6004620")]
			[Address(RVA = "0x285FC20", Offset = "0x285FD21", VA = "0x285FC20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004621")]
		[Address(RVA = "0x2860390", Offset = "0x2860491", VA = "0x2860390")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600541B RID: 21531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004622")]
		[Address(RVA = "0x2860580", Offset = "0x2860681", VA = "0x2860580")]
		protected PickUp2Handed()
		{
		}

		// Token: 0x0400B341 RID: 45889
		[Token(Token = "0x400869F")]
		[FieldOffset(Offset = "0x18")]
		public int GUIspace;

		// Token: 0x0400B342 RID: 45890
		[Token(Token = "0x40086A0")]
		[FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		// Token: 0x0400B343 RID: 45891
		[Token(Token = "0x40086A1")]
		[FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		// Token: 0x0400B344 RID: 45892
		[Token(Token = "0x40086A2")]
		[FieldOffset(Offset = "0x30")]
		public Transform pivot;

		// Token: 0x0400B345 RID: 45893
		[Token(Token = "0x40086A3")]
		[FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		// Token: 0x0400B346 RID: 45894
		[Token(Token = "0x40086A4")]
		[FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		// Token: 0x0400B347 RID: 45895
		[Token(Token = "0x40086A5")]
		[FieldOffset(Offset = "0x44")]
		private float holdWeight;

		// Token: 0x0400B348 RID: 45896
		[Token(Token = "0x40086A6")]
		[FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		// Token: 0x0400B349 RID: 45897
		[Token(Token = "0x40086A7")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		// Token: 0x0400B34A RID: 45898
		[Token(Token = "0x40086A8")]
		[FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;
	}
}
