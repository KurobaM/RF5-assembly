using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000E02 RID: 3586
	[Token(Token = "0x200092A")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x148D60", Offset = "0x148E61")]
	public class TimeOfDayController : MonoBehaviour
	{
		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06005D3D RID: 23869 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005D3E RID: 23870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009A6")]
		public static TimeOfDayController instance
		{
			[Token(Token = "0x6004D58")]
			[Address(RVA = "0x23EB3C0", Offset = "0x23EB4C1", VA = "0x23EB3C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABD60", Offset = "0x1ABE61")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D59")]
			[Address(RVA = "0x23EB410", Offset = "0x23EB511", VA = "0x23EB410")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABD70", Offset = "0x1ABE71")]
			private set
			{
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06005D3F RID: 23871 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005D40 RID: 23872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009A7")]
		public SkyProfile skyProfile
		{
			[Token(Token = "0x6004D5A")]
			[Address(RVA = "0x23EB470", Offset = "0x23EB571", VA = "0x23EB470")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D5B")]
			[Address(RVA = "0x23EB480", Offset = "0x23EB581", VA = "0x23EB480")]
			set
			{
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06005D41 RID: 23873 RVA: 0x0001EE70 File Offset: 0x0001D070
		// (set) Token: 0x06005D42 RID: 23874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009A8")]
		public float skyTime
		{
			[Token(Token = "0x6004D5C")]
			[Address(RVA = "0x23EE410", Offset = "0x23EE511", VA = "0x23EE410")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004D5D")]
			[Address(RVA = "0x23EE420", Offset = "0x23EE521", VA = "0x23EE420")]
			set
			{
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06005D43 RID: 23875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009A9")]
		public SkyMaterialController SkyMaterial
		{
			[Token(Token = "0x6004D5E")]
			[Address(RVA = "0x23EE4A0", Offset = "0x23EE5A1", VA = "0x23EE4A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06005D44 RID: 23876 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005D45 RID: 23877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000007")]
		public event TimeOfDayController.TimeOfDayDidChange timeChangedCallback
		{
			[Token(Token = "0x6004D5F")]
			[Address(RVA = "0x23EE4B0", Offset = "0x23EE5B1", VA = "0x23EE4B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABD80", Offset = "0x1ABE81")]
			add
			{
			}
			[Token(Token = "0x6004D60")]
			[Address(RVA = "0x23EE560", Offset = "0x23EE661", VA = "0x23EE560")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABD90", Offset = "0x1ABE91")]
			remove
			{
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06005D46 RID: 23878 RVA: 0x0001EE88 File Offset: 0x0001D088
		[Token(Token = "0x170009AA")]
		public float timeOfDay
		{
			[Token(Token = "0x6004D61")]
			[Address(RVA = "0x23EE610", Offset = "0x23EE711", VA = "0x23EE610")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06005D47 RID: 23879 RVA: 0x0001EEA0 File Offset: 0x0001D0A0
		[Token(Token = "0x170009AB")]
		public int daysElapsed
		{
			[Token(Token = "0x6004D62")]
			[Address(RVA = "0x23EE630", Offset = "0x23EE731", VA = "0x23EE630")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005D48 RID: 23880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D63")]
		[Address(RVA = "0x23EE640", Offset = "0x23EE741", VA = "0x23EE640")]
		private void Awake()
		{
		}

		// Token: 0x06005D49 RID: 23881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D64")]
		[Address(RVA = "0x23EE6A0", Offset = "0x23EE7A1", VA = "0x23EE6A0")]
		private void OnEnabled()
		{
		}

		// Token: 0x06005D4A RID: 23882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D65")]
		[Address(RVA = "0x23EE720", Offset = "0x23EE821", VA = "0x23EE720")]
		private void OnValidate()
		{
		}

		// Token: 0x06005D4B RID: 23883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D66")]
		[Address(RVA = "0x23EE7D0", Offset = "0x23EE8D1", VA = "0x23EE7D0")]
		private void WarnInvalidSkySetup()
		{
		}

		// Token: 0x06005D4C RID: 23884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D67")]
		[Address(RVA = "0x23EE840", Offset = "0x23EE941", VA = "0x23EE840")]
		private void Update()
		{
		}

		// Token: 0x06005D4D RID: 23885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D68")]
		[Address(RVA = "0x23EF0C0", Offset = "0x23EF1C1", VA = "0x23EF0C0")]
		public void UpdateGlobalIllumination()
		{
		}

		// Token: 0x06005D4E RID: 23886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D69")]
		[Address(RVA = "0x23EE1F0", Offset = "0x23EE2F1", VA = "0x23EE1F0")]
		private void SynchronizeAllShaderKeywords()
		{
		}

		// Token: 0x06005D4F RID: 23887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D6A")]
		[Address(RVA = "0x23EF0D0", Offset = "0x23EF1D1", VA = "0x23EF0D0")]
		private void SynchronizedShaderKeyword(string featureKey, string shaderKeyword)
		{
		}

		// Token: 0x06005D50 RID: 23888 RVA: 0x0001EEB8 File Offset: 0x0001D0B8
		[Token(Token = "0x6004D6B")]
		[Address(RVA = "0x23EF240", Offset = "0x23EF341", VA = "0x23EF240")]
		private Vector3 GetPrimaryLightDirection()
		{
			return default(Vector3);
		}

		// Token: 0x06005D51 RID: 23889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D6C")]
		[Address(RVA = "0x23EB570", Offset = "0x23EB671", VA = "0x23EB570")]
		public void UpdateSkyForCurrentTime()
		{
		}

		// Token: 0x06005D52 RID: 23890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D6D")]
		[Address(RVA = "0x23EF810", Offset = "0x23EF911", VA = "0x23EF810")]
		public TimeOfDayController()
		{
		}

		// Token: 0x0400BD79 RID: 48505
		[Token(Token = "0x4008DE6")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17E050", Offset = "0x17E151")]
		private static TimeOfDayController <instance>k__BackingField;

		// Token: 0x0400BD7A RID: 48506
		[Token(Token = "0x4008DE7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E060", Offset = "0x17E161")]
		[SerializeField]
		private SkyProfile m_SkyProfile;

		// Token: 0x0400BD7B RID: 48507
		[Token(Token = "0x4008DE8")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E0B0", Offset = "0x17E1B1")]
		[SerializeField]
		private float m_SkyTime;

		// Token: 0x0400BD7C RID: 48508
		[Token(Token = "0x4008DE9")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E100", Offset = "0x17E201")]
		public bool automaticTimeIncrement;

		// Token: 0x0400BD7D RID: 48509
		[Token(Token = "0x4008DEA")]
		[FieldOffset(Offset = "0x25")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E140", Offset = "0x17E241")]
		public bool copySkyProfile;

		// Token: 0x0400BD7E RID: 48510
		[Token(Token = "0x4008DEB")]
		[FieldOffset(Offset = "0x28")]
		private SkyMaterialController m_SkyMaterialController;

		// Token: 0x0400BD7F RID: 48511
		[Token(Token = "0x4008DEC")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E180", Offset = "0x17E281")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17E180", Offset = "0x17E281")]
		public float automaticIncrementSpeed;

		// Token: 0x0400BD80 RID: 48512
		[Token(Token = "0x4008DED")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E1E0", Offset = "0x17E2E1")]
		public OrbitingBody sunOrbit;

		// Token: 0x0400BD81 RID: 48513
		[Token(Token = "0x4008DEE")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E220", Offset = "0x17E321")]
		public OrbitingBody moonOrbit;

		// Token: 0x0400BD82 RID: 48514
		[Token(Token = "0x4008DEF")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E260", Offset = "0x17E361")]
		public WeatherController weatherController;

		// Token: 0x0400BD83 RID: 48515
		[Token(Token = "0x4008DF0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E2A0", Offset = "0x17E3A1")]
		public bool updateGlobalIllumination;

		// Token: 0x0400BD85 RID: 48517
		[Token(Token = "0x4008DF2")]
		[FieldOffset(Offset = "0x60")]
		private bool m_DidInitialUpdate;

		// Token: 0x0400BD86 RID: 48518
		[Token(Token = "0x4008DF3")]
		private const float PointMoveThreshold = 3E-06f;

		// Token: 0x02000E03 RID: 3587
		// (Invoke) Token: 0x06005D54 RID: 23892
		[Token(Token = "0x2001445")]
		public delegate void TimeOfDayDidChange(TimeOfDayController tc, float timeOfDay);
	}
}
