using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cinemachine;
using Define;
using Il2CppDummyDll;
using Serialize;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

// Token: 0x0200019B RID: 411
[Token(Token = "0x2000146")]
public class CameraManager : SingletonMonoBehaviour<CameraManager>
{
	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x06000878 RID: 2168 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000877 RID: 2167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700018E")]
	public Camera MainCamera
	{
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x1E76B90", Offset = "0x1E76C91", VA = "0x1E76B90")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x1E76B00", Offset = "0x1E76C01", VA = "0x1E76B00")]
		private set
		{
		}
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x0600087A RID: 2170 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000879 RID: 2169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700018F")]
	public CinemachineBrain CinemachineBrain
	{
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x1E76BB0", Offset = "0x1E76CB1", VA = "0x1E76BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x1E76BA0", Offset = "0x1E76CA1", VA = "0x1E76BA0")]
		private set
		{
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x0600087B RID: 2171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000190")]
	public FxPro FxPro
	{
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1E76BC0", Offset = "0x1E76CC1", VA = "0x1E76BC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x0600087C RID: 2172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000191")]
	public Bloom Bloom
	{
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x1E76BD0", Offset = "0x1E76CD1", VA = "0x1E76BD0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x0600087E RID: 2174 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600087D RID: 2173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000192")]
	public PlayerCameraController PlayerCameraController
	{
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x1E76BF0", Offset = "0x1E76CF1", VA = "0x1E76BF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AB70", Offset = "0x19AC71")]
		get
		{
			return null;
		}
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1E76BE0", Offset = "0x1E76CE1", VA = "0x1E76BE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AB60", Offset = "0x19AC61")]
		private set
		{
		}
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x06000880 RID: 2176 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600087F RID: 2175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000193")]
	public ShortPlayCameraController ShortPlayCameraController
	{
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1E76C10", Offset = "0x1E76D11", VA = "0x1E76C10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AB90", Offset = "0x19AC91")]
		get
		{
			return null;
		}
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1E76C00", Offset = "0x1E76D01", VA = "0x1E76C00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AB80", Offset = "0x19AC81")]
		private set
		{
		}
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x06000882 RID: 2178 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000881 RID: 2177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000194")]
	public FishingCameraController FishingCameraController
	{
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1E76C30", Offset = "0x1E76D31", VA = "0x1E76C30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19ABB0", Offset = "0x19ACB1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1E76C20", Offset = "0x1E76D21", VA = "0x1E76C20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19ABA0", Offset = "0x19ACA1")]
		private set
		{
		}
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x06000884 RID: 2180 RVA: 0x00004CF8 File Offset: 0x00002EF8
	// (set) Token: 0x06000883 RID: 2179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000195")]
	public UseCameraType CurrentCameraType
	{
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1E76C50", Offset = "0x1E76D51", VA = "0x1E76C50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19ABD0", Offset = "0x19ACD1")]
		get
		{
			return UseCameraType.Empty;
		}
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1E76C40", Offset = "0x1E76D41", VA = "0x1E76C40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19ABC0", Offset = "0x19ACC1")]
		private set
		{
		}
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000755")]
	[Address(RVA = "0x1E76C60", Offset = "0x1E76D61", VA = "0x1E76C60", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000756")]
	[Address(RVA = "0x1E773C0", Offset = "0x1E774C1", VA = "0x1E773C0")]
	private void Start()
	{
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000757")]
	[Address(RVA = "0x1E773E0", Offset = "0x1E774E1", VA = "0x1E773E0")]
	private void Update()
	{
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000758")]
	[Address(RVA = "0x1E777A0", Offset = "0x1E778A1", VA = "0x1E777A0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000759")]
	[Address(RVA = "0x1E779D0", Offset = "0x1E77AD1", VA = "0x1E779D0")]
	public void UseCamera(UseCameraType cameraType, bool isForceBlendCut = false)
	{
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075A")]
	[Address(RVA = "0x1E77DE0", Offset = "0x1E77EE1", VA = "0x1E77DE0")]
	public void UsePlayableCamera()
	{
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075B")]
	[Address(RVA = "0x1E78190", Offset = "0x1E78291", VA = "0x1E78190")]
	public static void MainCameraSetActive(bool active)
	{
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075C")]
	[Address(RVA = "0x1E78370", Offset = "0x1E78471", VA = "0x1E78370")]
	public void SetupMiniGameCamera(CinemachineVirtualCameraBase cinemachineVirtualCameraBase)
	{
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075D")]
	[Address(RVA = "0x1E78390", Offset = "0x1E78491", VA = "0x1E78390")]
	public void SetupLandscapeCamera(CinemachineVirtualCameraBase cinemachineVirtualCameraBase)
	{
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075E")]
	[Address(RVA = "0x1E783B0", Offset = "0x1E784B1", VA = "0x1E783B0")]
	public void HideAllCullingMask()
	{
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075F")]
	[Address(RVA = "0x1E76B50", Offset = "0x1E76C51", VA = "0x1E76B50")]
	public void UnhideAllCullingMask()
	{
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000760")]
	[Address(RVA = "0x1E78410", Offset = "0x1E78511", VA = "0x1E78410")]
	public void SetActiveCamera(Camera setCamera)
	{
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000761")]
	[Address(RVA = "0x1E782A0", Offset = "0x1E783A1", VA = "0x1E782A0")]
	public void ResetActiveCamera(bool activeMainCamera = true)
	{
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000762")]
	[Address(RVA = "0x1E784E0", Offset = "0x1E785E1", VA = "0x1E784E0")]
	public Camera GetActiveCamera()
	{
		return null;
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000763")]
	[Address(RVA = "0x1E786E0", Offset = "0x1E787E1", VA = "0x1E786E0")]
	public void SetDOFTarget(Transform trans)
	{
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000764")]
	[Address(RVA = "0x1E78710", Offset = "0x1E78811", VA = "0x1E78710")]
	public void ResetDOFTarget()
	{
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000765")]
	[Address(RVA = "0x1E78740", Offset = "0x1E78841", VA = "0x1E78740")]
	public void ForceMoveMainCamra(UseCameraType useCameraType, CinemachineVirtualCamera cinemachineVirtualCamera)
	{
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000766")]
	[Address(RVA = "0x1E775B0", Offset = "0x1E776B1", VA = "0x1E775B0")]
	private void FrameUpdateCameraControllers()
	{
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000767")]
	[Address(RVA = "0x1E777B0", Offset = "0x1E778B1", VA = "0x1E777B0")]
	private void TimeStepUpdateCameraControllers()
	{
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x00004D10 File Offset: 0x00002F10
	[Token(Token = "0x6000768")]
	[Address(RVA = "0x1E78920", Offset = "0x1E78A21", VA = "0x1E78920")]
	private bool IsNotFrameUpdateCamera(UseCameraType useCameraType)
	{
		return default(bool);
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x00004D28 File Offset: 0x00002F28
	[Token(Token = "0x6000769")]
	[Address(RVA = "0x1E78A80", Offset = "0x1E78B81", VA = "0x1E78A80")]
	private bool IsNotTimeStepUpdateCamera(UseCameraType useCameraType)
	{
		return default(bool);
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600076A")]
	[Address(RVA = "0x1E77B20", Offset = "0x1E77C21", VA = "0x1E77B20")]
	private void SetUseCamera(UseCameraType cameraType)
	{
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600076B")]
	[Address(RVA = "0x1E77A80", Offset = "0x1E77B81", VA = "0x1E77A80")]
	private void SetUseCameraBlendCut(UseCameraType cameraType)
	{
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076C")]
	[Address(RVA = "0x1E78CE0", Offset = "0x1E78DE1", VA = "0x1E78CE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19ABE0", Offset = "0x19ACE1")]
	private IEnumerator BlendCutAsync(UseCameraType cameraType)
	{
		return null;
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076D")]
	[Address(RVA = "0x1E772A0", Offset = "0x1E773A1", VA = "0x1E772A0")]
	private CameraControllerBase GetCameraController(UseCameraType cameraType)
	{
		return null;
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600076E")]
	[Address(RVA = "0x1E78B20", Offset = "0x1E78C21", VA = "0x1E78B20")]
	private void DisableHigherPriorityVcamBase(UseCameraType cameraType)
	{
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x00004D40 File Offset: 0x00002F40
	[Token(Token = "0x600076F")]
	[Address(RVA = "0x1E77E10", Offset = "0x1E77F11", VA = "0x1E77E10")]
	private UseCameraType GetActiveCameraTypeFromPriority(CameraManager.VCamPriority priority)
	{
		return UseCameraType.Empty;
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000770")]
	[Address(RVA = "0x1E785C0", Offset = "0x1E786C1", VA = "0x1E785C0")]
	private Camera FindActiveCamera()
	{
		return null;
	}

	// Token: 0x060008A1 RID: 2209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000771")]
	[Address(RVA = "0x1E77410", Offset = "0x1E77511", VA = "0x1E77410")]
	private void UpdateActiveCamera()
	{
	}

	// Token: 0x060008A2 RID: 2210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000772")]
	[Address(RVA = "0x1E78DA0", Offset = "0x1E78EA1", VA = "0x1E78DA0")]
	public CameraManager()
	{
	}

	// Token: 0x040004F6 RID: 1270
	[Token(Token = "0x40003DA")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<UseCameraType, int> GetSelectVcamBasePriority;

	// Token: 0x040004F7 RID: 1271
	[Token(Token = "0x40003DB")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C780", Offset = "0x15C881")]
	private PlayerCameraController <PlayerCameraController>k__BackingField;

	// Token: 0x040004F8 RID: 1272
	[Token(Token = "0x40003DC")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C790", Offset = "0x15C891")]
	private ShortPlayCameraController <ShortPlayCameraController>k__BackingField;

	// Token: 0x040004F9 RID: 1273
	[Token(Token = "0x40003DD")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C7A0", Offset = "0x15C8A1")]
	private FishingCameraController <FishingCameraController>k__BackingField;

	// Token: 0x040004FA RID: 1274
	[Token(Token = "0x40003DE")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C7B0", Offset = "0x15C8B1")]
	private UseCameraType <CurrentCameraType>k__BackingField;

	// Token: 0x040004FB RID: 1275
	[Token(Token = "0x40003DF")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Camera _MainCamera;

	// Token: 0x040004FC RID: 1276
	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private CinemachineBrain _CinemachineBrain;

	// Token: 0x040004FD RID: 1277
	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private FxPro _FxPro;

	// Token: 0x040004FE RID: 1278
	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Bloom _Bloom;

	// Token: 0x040004FF RID: 1279
	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<CameraManager.CameraControllerPair> CameraControllerPairs;

	// Token: 0x04000500 RID: 1280
	[Token(Token = "0x40003E4")]
	[FieldOffset(Offset = "0x68")]
	private UseCameraType PrevCameraType;

	// Token: 0x04000501 RID: 1281
	[Token(Token = "0x40003E5")]
	[FieldOffset(Offset = "0x6C")]
	private bool IsHideCullingMask;

	// Token: 0x04000502 RID: 1282
	[Token(Token = "0x40003E6")]
	[FieldOffset(Offset = "0x70")]
	private int DefaultCullingMask;

	// Token: 0x04000503 RID: 1283
	[Token(Token = "0x40003E7")]
	[FieldOffset(Offset = "0x78")]
	private Camera ActiveCamera;

	// Token: 0x04000504 RID: 1284
	[Token(Token = "0x40003E8")]
	[FieldOffset(Offset = "0x80")]
	public OnChangeActiveCameraEvent OnChangeActiveCamaraEvent;

	// Token: 0x04000505 RID: 1285
	[Token(Token = "0x40003E9")]
	[FieldOffset(Offset = "0x88")]
	private Transform NearCameraTargetTransform;

	// Token: 0x04000506 RID: 1286
	[Token(Token = "0x40003EA")]
	[FieldOffset(Offset = "0x90")]
	private CinemachineBrain.BrainUpdateMethod TempBrainUpdateMethod;

	// Token: 0x0200019C RID: 412
	[Token(Token = "0x2000FDE")]
	private enum VCamPriority
	{
		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4018D90")]
		UnUse,
		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4018D91")]
		Default = 10,
		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x4018D92")]
		Player,
		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x4018D93")]
		Farm = 20,
		// Token: 0x0400050C RID: 1292
		[Token(Token = "0x4018D94")]
		Fishing,
		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x4018D95")]
		Playable = 30,
		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x4018D96")]
		Landscape = 100,
		// Token: 0x0400050F RID: 1295
		[Token(Token = "0x4018D97")]
		LifeCycle = 300,
		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4018D98")]
		ShortPlay = 310,
		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4018D99")]
		MiniGame = 500,
		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4018D9A")]
		Debug = 999,
		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4018D9B")]
		CutBuffur
	}

	// Token: 0x0200019D RID: 413
	[Token(Token = "0x2000FDF")]
	[Serializable]
	public class CameraControllerPair : KeyAndValue<UseCameraType, CameraControllerBase>
	{
		// Token: 0x060008A3 RID: 2211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C1B")]
		[Address(RVA = "0x1E790D0", Offset = "0x1E791D1", VA = "0x1E790D0")]
		public CameraControllerPair(UseCameraType cameraType, CameraControllerBase cameraControllerBase)
		{
		}
	}

	// Token: 0x0200019E RID: 414
	[Token(Token = "0x2000FE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1571F0", Offset = "0x1572F1")]
	private sealed class <BlendCutAsync>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060008A4 RID: 2212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C1C")]
		[Address(RVA = "0x1E78D70", Offset = "0x1E78E71", VA = "0x1E78D70")]
		[DebuggerHidden]
		public <BlendCutAsync>d__64(int <>1__state)
		{
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C1D")]
		[Address(RVA = "0x1E78FB0", Offset = "0x1E790B1", VA = "0x1E78FB0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x6006C1E")]
		[Address(RVA = "0x1E78FC0", Offset = "0x1E790C1", VA = "0x1E78FC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD2")]
		private object Current
		{
			[Token(Token = "0x6006C1F")]
			[Address(RVA = "0x1E79050", Offset = "0x1E79151", VA = "0x1E79050", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C20")]
		[Address(RVA = "0x1E79060", Offset = "0x1E79161", VA = "0x1E79060", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD3")]
		private object Current
		{
			[Token(Token = "0x6006C21")]
			[Address(RVA = "0x1E790C0", Offset = "0x1E791C1", VA = "0x1E790C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4018D9C")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4018D9D")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4018D9E")]
		[FieldOffset(Offset = "0x20")]
		public CameraManager <>4__this;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4018D9F")]
		[FieldOffset(Offset = "0x28")]
		public UseCameraType cameraType;
	}

	// Token: 0x0200019F RID: 415
	[Token(Token = "0x2000FE1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157200", Offset = "0x157301")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060008AB RID: 2219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C23")]
		[Address(RVA = "0x1E78F50", Offset = "0x1E79051", VA = "0x1E78F50")]
		public <>c()
		{
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x6006C24")]
		[Address(RVA = "0x1E78F60", Offset = "0x1E79061", VA = "0x1E78F60")]
		internal int <GetActiveCameraTypeFromPriority>b__67_0(CameraManager.CameraControllerPair a, CameraManager.CameraControllerPair b)
		{
			return 0;
		}

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x4018DA0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CameraManager.<>c <>9;

		// Token: 0x04000519 RID: 1305
		[Token(Token = "0x4018DA1")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<CameraManager.CameraControllerPair> <>9__67_0;
	}
}
