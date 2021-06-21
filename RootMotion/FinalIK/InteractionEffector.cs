using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D58 RID: 3416
	[Token(Token = "0x20008CA")]
	[Serializable]
	public class InteractionEffector
	{
		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06005883 RID: 22659 RVA: 0x0001D1A8 File Offset: 0x0001B3A8
		// (set) Token: 0x06005884 RID: 22660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008E0")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6004968")]
			[Address(RVA = "0x2CD8F10", Offset = "0x2CD9011", VA = "0x2CD8F10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AAC20", Offset = "0x1AAD21")]
			get
			{
				return FullBodyBipedEffector.Body;
			}
			[Token(Token = "0x6004969")]
			[Address(RVA = "0x2CD8F20", Offset = "0x2CD9021", VA = "0x2CD8F20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AAC30", Offset = "0x1AAD31")]
			private set
			{
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06005885 RID: 22661 RVA: 0x0001D1C0 File Offset: 0x0001B3C0
		// (set) Token: 0x06005886 RID: 22662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008E1")]
		public bool isPaused
		{
			[Token(Token = "0x600496A")]
			[Address(RVA = "0x2CD8F30", Offset = "0x2CD9031", VA = "0x2CD8F30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AAC40", Offset = "0x1AAD41")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600496B")]
			[Address(RVA = "0x2CD8F40", Offset = "0x2CD9041", VA = "0x2CD8F40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AAC50", Offset = "0x1AAD51")]
			private set
			{
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06005887 RID: 22663 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005888 RID: 22664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008E2")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x600496C")]
			[Address(RVA = "0x2CD8F50", Offset = "0x2CD9051", VA = "0x2CD8F50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AAC60", Offset = "0x1AAD61")]
			get
			{
				return null;
			}
			[Token(Token = "0x600496D")]
			[Address(RVA = "0x2CD8F60", Offset = "0x2CD9061", VA = "0x2CD8F60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AAC70", Offset = "0x1AAD71")]
			private set
			{
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06005889 RID: 22665 RVA: 0x0001D1D8 File Offset: 0x0001B3D8
		[Token(Token = "0x170008E3")]
		public bool inInteraction
		{
			[Token(Token = "0x600496E")]
			[Address(RVA = "0x2CD8F70", Offset = "0x2CD9071", VA = "0x2CD8F70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600588A RID: 22666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600496F")]
		[Address(RVA = "0x2CD8FE0", Offset = "0x2CD90E1", VA = "0x2CD8FE0")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		// Token: 0x0600588B RID: 22667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004970")]
		[Address(RVA = "0x2CD9070", Offset = "0x2CD9171", VA = "0x2CD9070")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004971")]
		[Address(RVA = "0x2CD9140", Offset = "0x2CD9241", VA = "0x2CD9140")]
		private void StoreDefaults()
		{
		}

		// Token: 0x0600588D RID: 22669 RVA: 0x0001D1F0 File Offset: 0x0001B3F0
		[Token(Token = "0x6004972")]
		[Address(RVA = "0x2CD92C0", Offset = "0x2CD93C1", VA = "0x2CD92C0")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		// Token: 0x0600588E RID: 22670 RVA: 0x0001D208 File Offset: 0x0001B408
		[Token(Token = "0x6004973")]
		[Address(RVA = "0x2CD97B0", Offset = "0x2CD98B1", VA = "0x2CD97B0")]
		public bool Pause()
		{
			return default(bool);
		}

		// Token: 0x0600588F RID: 22671 RVA: 0x0001D220 File Offset: 0x0001B420
		[Token(Token = "0x6004974")]
		[Address(RVA = "0x2CD9C00", Offset = "0x2CD9D01", VA = "0x2CD9C00")]
		public bool Resume()
		{
			return default(bool);
		}

		// Token: 0x06005890 RID: 22672 RVA: 0x0001D238 File Offset: 0x0001B438
		[Token(Token = "0x6004975")]
		[Address(RVA = "0x2CD9CB0", Offset = "0x2CD9DB1", VA = "0x2CD9CB0")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		// Token: 0x06005891 RID: 22673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004976")]
		[Address(RVA = "0x2CDA900", Offset = "0x2CDAA01", VA = "0x2CDA900")]
		public void Update(Transform root, float speed)
		{
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06005892 RID: 22674 RVA: 0x0001D250 File Offset: 0x0001B450
		[Token(Token = "0x170008E4")]
		public float progress
		{
			[Token(Token = "0x6004977")]
			[Address(RVA = "0x2CDC080", Offset = "0x2CDC181", VA = "0x2CDC080")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06005893 RID: 22675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004978")]
		[Address(RVA = "0x2CDB640", Offset = "0x2CDB741", VA = "0x2CDB640")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004979")]
		[Address(RVA = "0x2CDB880", Offset = "0x2CDB981", VA = "0x2CDB880")]
		private void PickUp(Transform root)
		{
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x0001D268 File Offset: 0x0001B468
		[Token(Token = "0x600497A")]
		[Address(RVA = "0x2CDBEB0", Offset = "0x2CDBFB1", VA = "0x2CDBEB0")]
		public bool Stop()
		{
			return default(bool);
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600497B")]
		[Address(RVA = "0x2CDC610", Offset = "0x2CDC711", VA = "0x2CDC610")]
		public void OnPostFBBIK()
		{
		}

		// Token: 0x0400B7DF RID: 47071
		[Token(Token = "0x40089C1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17B0A0", Offset = "0x17B1A1")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		// Token: 0x0400B7E0 RID: 47072
		[Token(Token = "0x40089C2")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17B0B0", Offset = "0x17B1B1")]
		private bool <isPaused>k__BackingField;

		// Token: 0x0400B7E1 RID: 47073
		[Token(Token = "0x40089C3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17B0C0", Offset = "0x17B1C1")]
		private InteractionObject <interactionObject>k__BackingField;

		// Token: 0x0400B7E2 RID: 47074
		[Token(Token = "0x40089C4")]
		[FieldOffset(Offset = "0x20")]
		private Poser poser;

		// Token: 0x0400B7E3 RID: 47075
		[Token(Token = "0x40089C5")]
		[FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		// Token: 0x0400B7E4 RID: 47076
		[Token(Token = "0x40089C6")]
		[FieldOffset(Offset = "0x30")]
		private float timer;

		// Token: 0x0400B7E5 RID: 47077
		[Token(Token = "0x40089C7")]
		[FieldOffset(Offset = "0x34")]
		private float length;

		// Token: 0x0400B7E6 RID: 47078
		[Token(Token = "0x40089C8")]
		[FieldOffset(Offset = "0x38")]
		private float weight;

		// Token: 0x0400B7E7 RID: 47079
		[Token(Token = "0x40089C9")]
		[FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		// Token: 0x0400B7E8 RID: 47080
		[Token(Token = "0x40089CA")]
		[FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		// Token: 0x0400B7E9 RID: 47081
		[Token(Token = "0x40089CB")]
		[FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		// Token: 0x0400B7EA RID: 47082
		[Token(Token = "0x40089CC")]
		[FieldOffset(Offset = "0x48")]
		private float defaultPull;

		// Token: 0x0400B7EB RID: 47083
		[Token(Token = "0x40089CD")]
		[FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		// Token: 0x0400B7EC RID: 47084
		[Token(Token = "0x40089CE")]
		[FieldOffset(Offset = "0x50")]
		private float defaultPush;

		// Token: 0x0400B7ED RID: 47085
		[Token(Token = "0x40089CF")]
		[FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		// Token: 0x0400B7EE RID: 47086
		[Token(Token = "0x40089D0")]
		[FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		// Token: 0x0400B7EF RID: 47087
		[Token(Token = "0x40089D1")]
		[FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		// Token: 0x0400B7F0 RID: 47088
		[Token(Token = "0x40089D2")]
		[FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		// Token: 0x0400B7F1 RID: 47089
		[Token(Token = "0x40089D3")]
		[FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		// Token: 0x0400B7F2 RID: 47090
		[Token(Token = "0x40089D4")]
		[FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		// Token: 0x0400B7F3 RID: 47091
		[Token(Token = "0x40089D5")]
		[FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		// Token: 0x0400B7F4 RID: 47092
		[Token(Token = "0x40089D6")]
		[FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		// Token: 0x0400B7F5 RID: 47093
		[Token(Token = "0x40089D7")]
		[FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		// Token: 0x0400B7F6 RID: 47094
		[Token(Token = "0x40089D8")]
		[FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		// Token: 0x0400B7F7 RID: 47095
		[Token(Token = "0x40089D9")]
		[FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		// Token: 0x0400B7F8 RID: 47096
		[Token(Token = "0x40089DA")]
		[FieldOffset(Offset = "0x68")]
		private bool defaults;

		// Token: 0x0400B7F9 RID: 47097
		[Token(Token = "0x40089DB")]
		[FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		// Token: 0x0400B7FA RID: 47098
		[Token(Token = "0x40089DC")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		// Token: 0x0400B7FB RID: 47099
		[Token(Token = "0x40089DD")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		// Token: 0x0400B7FC RID: 47100
		[Token(Token = "0x40089DE")]
		[FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		// Token: 0x0400B7FD RID: 47101
		[Token(Token = "0x40089DF")]
		[FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		// Token: 0x0400B7FE RID: 47102
		[Token(Token = "0x40089E0")]
		[FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		// Token: 0x0400B7FF RID: 47103
		[Token(Token = "0x40089E1")]
		[FieldOffset(Offset = "0xB0")]
		private Transform target;

		// Token: 0x0400B800 RID: 47104
		[Token(Token = "0x40089E2")]
		[FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		// Token: 0x0400B801 RID: 47105
		[Token(Token = "0x40089E3")]
		[FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		// Token: 0x0400B802 RID: 47106
		[Token(Token = "0x40089E4")]
		[FieldOffset(Offset = "0xC8")]
		private bool started;
	}
}
