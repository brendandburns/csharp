// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// PersistentVolumeSpec is the specification of a persistent volume.
    /// </summary>
    public partial class V1PersistentVolumeSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1PersistentVolumeSpec class.
        /// </summary>
        public V1PersistentVolumeSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1PersistentVolumeSpec class.
        /// </summary>
        /// <param name="accessModes">AccessModes contains all ways the volume
        /// can be mounted. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes</param>
        /// <param name="awsElasticBlockStore">AWSElasticBlockStore represents
        /// an AWS Disk resource that is attached to a kubelet's host machine
        /// and then exposed to the pod. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</param>
        /// <param name="azureDisk">AzureDisk represents an Azure Data Disk
        /// mount on the host and bind mount to the pod.</param>
        /// <param name="azureFile">AzureFile represents an Azure File Service
        /// mount on the host and bind mount to the pod.</param>
        /// <param name="capacity">A description of the persistent volume's
        /// resources and capacity. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity</param>
        /// <param name="cephfs">CephFS represents a Ceph FS mount on the host
        /// that shares a pod's lifetime</param>
        /// <param name="cinder">Cinder represents a cinder volume attached and
        /// mounted on kubelets host machine. More info:
        /// https://examples.k8s.io/mysql-cinder-pd/README.md</param>
        /// <param name="claimRef">ClaimRef is part of a bi-directional binding
        /// between PersistentVolume and PersistentVolumeClaim. Expected to be
        /// non-nil when bound. claim.VolumeName is the authoritative bind
        /// between PV and PVC. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#binding</param>
        /// <param name="csi">CSI represents storage that is handled by an
        /// external CSI driver (Beta feature).</param>
        /// <param name="fc">FC represents a Fibre Channel resource that is
        /// attached to a kubelet's host machine and then exposed to the
        /// pod.</param>
        /// <param name="flexVolume">FlexVolume represents a generic volume
        /// resource that is provisioned/attached using an exec based
        /// plugin.</param>
        /// <param name="flocker">Flocker represents a Flocker volume attached
        /// to a kubelet's host machine and exposed to the pod for its usage.
        /// This depends on the Flocker control service being running</param>
        /// <param name="gcePersistentDisk">GCEPersistentDisk represents a GCE
        /// Disk resource that is attached to a kubelet's host machine and then
        /// exposed to the pod. Provisioned by an admin. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</param>
        /// <param name="glusterfs">Glusterfs represents a Glusterfs volume
        /// that is attached to a host and exposed to the pod. Provisioned by
        /// an admin. More info:
        /// https://examples.k8s.io/volumes/glusterfs/README.md</param>
        /// <param name="hostPath">HostPath represents a directory on the host.
        /// Provisioned by a developer or tester. This is useful for
        /// single-node development and testing only! On-host storage is not
        /// supported in any way and WILL NOT WORK in a multi-node cluster.
        /// More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#hostpath</param>
        /// <param name="iscsi">ISCSI represents an ISCSI Disk resource that is
        /// attached to a kubelet's host machine and then exposed to the pod.
        /// Provisioned by an admin.</param>
        /// <param name="local">Local represents directly-attached storage with
        /// node affinity</param>
        /// <param name="mountOptions">A list of mount options, e.g. ["ro",
        /// "soft"]. Not validated - mount will simply fail if one is invalid.
        /// More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes/#mount-options</param>
        /// <param name="nfs">NFS represents an NFS mount on the host.
        /// Provisioned by an admin. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#nfs</param>
        /// <param name="nodeAffinity">NodeAffinity defines constraints that
        /// limit what nodes this volume can be accessed from. This field
        /// influences the scheduling of pods that use this volume.</param>
        /// <param name="persistentVolumeReclaimPolicy">What happens to a
        /// persistent volume when released from its claim. Valid options are
        /// Retain (default for manually created PersistentVolumes), Delete
        /// (default for dynamically provisioned PersistentVolumes), and
        /// Recycle (deprecated). Recycle must be supported by the volume
        /// plugin underlying this PersistentVolume. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#reclaiming</param>
        /// <param name="photonPersistentDisk">PhotonPersistentDisk represents
        /// a PhotonController persistent disk attached and mounted on kubelets
        /// host machine</param>
        /// <param name="portworxVolume">PortworxVolume represents a portworx
        /// volume attached and mounted on kubelets host machine</param>
        /// <param name="quobyte">Quobyte represents a Quobyte mount on the
        /// host that shares a pod's lifetime</param>
        /// <param name="rbd">RBD represents a Rados Block Device mount on the
        /// host that shares a pod's lifetime. More info:
        /// https://examples.k8s.io/volumes/rbd/README.md</param>
        /// <param name="scaleIO">ScaleIO represents a ScaleIO persistent
        /// volume attached and mounted on Kubernetes nodes.</param>
        /// <param name="storageClassName">Name of StorageClass to which this
        /// persistent volume belongs. Empty value means that this volume does
        /// not belong to any StorageClass.</param>
        /// <param name="storageos">StorageOS represents a StorageOS volume
        /// that is attached to the kubelet's host machine and mounted into the
        /// pod More info:
        /// https://examples.k8s.io/volumes/storageos/README.md</param>
        /// <param name="volumeMode">volumeMode defines if a volume is intended
        /// to be used with a formatted filesystem or to remain in raw block
        /// state. Value of Filesystem is implied when not included in
        /// spec.</param>
        /// <param name="vsphereVolume">VsphereVolume represents a vSphere
        /// volume attached and mounted on kubelets host machine</param>
        public V1PersistentVolumeSpec(IList<string> accessModes = default(IList<string>), V1AWSElasticBlockStoreVolumeSource awsElasticBlockStore = default(V1AWSElasticBlockStoreVolumeSource), V1AzureDiskVolumeSource azureDisk = default(V1AzureDiskVolumeSource), V1AzureFilePersistentVolumeSource azureFile = default(V1AzureFilePersistentVolumeSource), IDictionary<string, string> capacity = default(IDictionary<string, string>), V1CephFSPersistentVolumeSource cephfs = default(V1CephFSPersistentVolumeSource), V1CinderPersistentVolumeSource cinder = default(V1CinderPersistentVolumeSource), V1ObjectReference claimRef = default(V1ObjectReference), V1CSIPersistentVolumeSource csi = default(V1CSIPersistentVolumeSource), V1FCVolumeSource fc = default(V1FCVolumeSource), V1FlexPersistentVolumeSource flexVolume = default(V1FlexPersistentVolumeSource), V1FlockerVolumeSource flocker = default(V1FlockerVolumeSource), V1GCEPersistentDiskVolumeSource gcePersistentDisk = default(V1GCEPersistentDiskVolumeSource), V1GlusterfsPersistentVolumeSource glusterfs = default(V1GlusterfsPersistentVolumeSource), V1HostPathVolumeSource hostPath = default(V1HostPathVolumeSource), V1ISCSIPersistentVolumeSource iscsi = default(V1ISCSIPersistentVolumeSource), V1LocalVolumeSource local = default(V1LocalVolumeSource), IList<string> mountOptions = default(IList<string>), V1NFSVolumeSource nfs = default(V1NFSVolumeSource), V1VolumeNodeAffinity nodeAffinity = default(V1VolumeNodeAffinity), string persistentVolumeReclaimPolicy = default(string), V1PhotonPersistentDiskVolumeSource photonPersistentDisk = default(V1PhotonPersistentDiskVolumeSource), V1PortworxVolumeSource portworxVolume = default(V1PortworxVolumeSource), V1QuobyteVolumeSource quobyte = default(V1QuobyteVolumeSource), V1RBDPersistentVolumeSource rbd = default(V1RBDPersistentVolumeSource), V1ScaleIOPersistentVolumeSource scaleIO = default(V1ScaleIOPersistentVolumeSource), string storageClassName = default(string), V1StorageOSPersistentVolumeSource storageos = default(V1StorageOSPersistentVolumeSource), string volumeMode = default(string), V1VsphereVirtualDiskVolumeSource vsphereVolume = default(V1VsphereVirtualDiskVolumeSource))
        {
            AccessModes = accessModes;
            AwsElasticBlockStore = awsElasticBlockStore;
            AzureDisk = azureDisk;
            AzureFile = azureFile;
            Capacity = capacity;
            Cephfs = cephfs;
            Cinder = cinder;
            ClaimRef = claimRef;
            Csi = csi;
            Fc = fc;
            FlexVolume = flexVolume;
            Flocker = flocker;
            GcePersistentDisk = gcePersistentDisk;
            Glusterfs = glusterfs;
            HostPath = hostPath;
            Iscsi = iscsi;
            Local = local;
            MountOptions = mountOptions;
            Nfs = nfs;
            NodeAffinity = nodeAffinity;
            PersistentVolumeReclaimPolicy = persistentVolumeReclaimPolicy;
            PhotonPersistentDisk = photonPersistentDisk;
            PortworxVolume = portworxVolume;
            Quobyte = quobyte;
            Rbd = rbd;
            ScaleIO = scaleIO;
            StorageClassName = storageClassName;
            Storageos = storageos;
            VolumeMode = volumeMode;
            VsphereVolume = vsphereVolume;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets accessModes contains all ways the volume can be
        /// mounted. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes
        /// </summary>
        [JsonProperty(PropertyName = "accessModes")]
        public IList<string> AccessModes { get; set; }

        /// <summary>
        /// Gets or sets aWSElasticBlockStore represents an AWS Disk resource
        /// that is attached to a kubelet's host machine and then exposed to
        /// the pod. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        [JsonProperty(PropertyName = "awsElasticBlockStore")]
        public V1AWSElasticBlockStoreVolumeSource AwsElasticBlockStore { get; set; }

        /// <summary>
        /// Gets or sets azureDisk represents an Azure Data Disk mount on the
        /// host and bind mount to the pod.
        /// </summary>
        [JsonProperty(PropertyName = "azureDisk")]
        public V1AzureDiskVolumeSource AzureDisk { get; set; }

        /// <summary>
        /// Gets or sets azureFile represents an Azure File Service mount on
        /// the host and bind mount to the pod.
        /// </summary>
        [JsonProperty(PropertyName = "azureFile")]
        public V1AzureFilePersistentVolumeSource AzureFile { get; set; }

        /// <summary>
        /// Gets or sets a description of the persistent volume's resources and
        /// capacity. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public IDictionary<string, string> Capacity { get; set; }

        /// <summary>
        /// Gets or sets cephFS represents a Ceph FS mount on the host that
        /// shares a pod's lifetime
        /// </summary>
        [JsonProperty(PropertyName = "cephfs")]
        public V1CephFSPersistentVolumeSource Cephfs { get; set; }

        /// <summary>
        /// Gets or sets cinder represents a cinder volume attached and mounted
        /// on kubelets host machine. More info:
        /// https://examples.k8s.io/mysql-cinder-pd/README.md
        /// </summary>
        [JsonProperty(PropertyName = "cinder")]
        public V1CinderPersistentVolumeSource Cinder { get; set; }

        /// <summary>
        /// Gets or sets claimRef is part of a bi-directional binding between
        /// PersistentVolume and PersistentVolumeClaim. Expected to be non-nil
        /// when bound. claim.VolumeName is the authoritative bind between PV
        /// and PVC. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#binding
        /// </summary>
        [JsonProperty(PropertyName = "claimRef")]
        public V1ObjectReference ClaimRef { get; set; }

        /// <summary>
        /// Gets or sets CSI represents storage that is handled by an external
        /// CSI driver (Beta feature).
        /// </summary>
        [JsonProperty(PropertyName = "csi")]
        public V1CSIPersistentVolumeSource Csi { get; set; }

        /// <summary>
        /// Gets or sets FC represents a Fibre Channel resource that is
        /// attached to a kubelet's host machine and then exposed to the pod.
        /// </summary>
        [JsonProperty(PropertyName = "fc")]
        public V1FCVolumeSource Fc { get; set; }

        /// <summary>
        /// Gets or sets flexVolume represents a generic volume resource that
        /// is provisioned/attached using an exec based plugin.
        /// </summary>
        [JsonProperty(PropertyName = "flexVolume")]
        public V1FlexPersistentVolumeSource FlexVolume { get; set; }

        /// <summary>
        /// Gets or sets flocker represents a Flocker volume attached to a
        /// kubelet's host machine and exposed to the pod for its usage. This
        /// depends on the Flocker control service being running
        /// </summary>
        [JsonProperty(PropertyName = "flocker")]
        public V1FlockerVolumeSource Flocker { get; set; }

        /// <summary>
        /// Gets or sets gCEPersistentDisk represents a GCE Disk resource that
        /// is attached to a kubelet's host machine and then exposed to the
        /// pod. Provisioned by an admin. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        [JsonProperty(PropertyName = "gcePersistentDisk")]
        public V1GCEPersistentDiskVolumeSource GcePersistentDisk { get; set; }

        /// <summary>
        /// Gets or sets glusterfs represents a Glusterfs volume that is
        /// attached to a host and exposed to the pod. Provisioned by an admin.
        /// More info: https://examples.k8s.io/volumes/glusterfs/README.md
        /// </summary>
        [JsonProperty(PropertyName = "glusterfs")]
        public V1GlusterfsPersistentVolumeSource Glusterfs { get; set; }

        /// <summary>
        /// Gets or sets hostPath represents a directory on the host.
        /// Provisioned by a developer or tester. This is useful for
        /// single-node development and testing only! On-host storage is not
        /// supported in any way and WILL NOT WORK in a multi-node cluster.
        /// More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        [JsonProperty(PropertyName = "hostPath")]
        public V1HostPathVolumeSource HostPath { get; set; }

        /// <summary>
        /// Gets or sets ISCSI represents an ISCSI Disk resource that is
        /// attached to a kubelet's host machine and then exposed to the pod.
        /// Provisioned by an admin.
        /// </summary>
        [JsonProperty(PropertyName = "iscsi")]
        public V1ISCSIPersistentVolumeSource Iscsi { get; set; }

        /// <summary>
        /// Gets or sets local represents directly-attached storage with node
        /// affinity
        /// </summary>
        [JsonProperty(PropertyName = "local")]
        public V1LocalVolumeSource Local { get; set; }

        /// <summary>
        /// Gets or sets a list of mount options, e.g. ["ro", "soft"]. Not
        /// validated - mount will simply fail if one is invalid. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes/#mount-options
        /// </summary>
        [JsonProperty(PropertyName = "mountOptions")]
        public IList<string> MountOptions { get; set; }

        /// <summary>
        /// Gets or sets NFS represents an NFS mount on the host. Provisioned
        /// by an admin. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#nfs
        /// </summary>
        [JsonProperty(PropertyName = "nfs")]
        public V1NFSVolumeSource Nfs { get; set; }

        /// <summary>
        /// Gets or sets nodeAffinity defines constraints that limit what nodes
        /// this volume can be accessed from. This field influences the
        /// scheduling of pods that use this volume.
        /// </summary>
        [JsonProperty(PropertyName = "nodeAffinity")]
        public V1VolumeNodeAffinity NodeAffinity { get; set; }

        /// <summary>
        /// Gets or sets what happens to a persistent volume when released from
        /// its claim. Valid options are Retain (default for manually created
        /// PersistentVolumes), Delete (default for dynamically provisioned
        /// PersistentVolumes), and Recycle (deprecated). Recycle must be
        /// supported by the volume plugin underlying this PersistentVolume.
        /// More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#reclaiming
        /// </summary>
        [JsonProperty(PropertyName = "persistentVolumeReclaimPolicy")]
        public string PersistentVolumeReclaimPolicy { get; set; }

        /// <summary>
        /// Gets or sets photonPersistentDisk represents a PhotonController
        /// persistent disk attached and mounted on kubelets host machine
        /// </summary>
        [JsonProperty(PropertyName = "photonPersistentDisk")]
        public V1PhotonPersistentDiskVolumeSource PhotonPersistentDisk { get; set; }

        /// <summary>
        /// Gets or sets portworxVolume represents a portworx volume attached
        /// and mounted on kubelets host machine
        /// </summary>
        [JsonProperty(PropertyName = "portworxVolume")]
        public V1PortworxVolumeSource PortworxVolume { get; set; }

        /// <summary>
        /// Gets or sets quobyte represents a Quobyte mount on the host that
        /// shares a pod's lifetime
        /// </summary>
        [JsonProperty(PropertyName = "quobyte")]
        public V1QuobyteVolumeSource Quobyte { get; set; }

        /// <summary>
        /// Gets or sets RBD represents a Rados Block Device mount on the host
        /// that shares a pod's lifetime. More info:
        /// https://examples.k8s.io/volumes/rbd/README.md
        /// </summary>
        [JsonProperty(PropertyName = "rbd")]
        public V1RBDPersistentVolumeSource Rbd { get; set; }

        /// <summary>
        /// Gets or sets scaleIO represents a ScaleIO persistent volume
        /// attached and mounted on Kubernetes nodes.
        /// </summary>
        [JsonProperty(PropertyName = "scaleIO")]
        public V1ScaleIOPersistentVolumeSource ScaleIO { get; set; }

        /// <summary>
        /// Gets or sets name of StorageClass to which this persistent volume
        /// belongs. Empty value means that this volume does not belong to any
        /// StorageClass.
        /// </summary>
        [JsonProperty(PropertyName = "storageClassName")]
        public string StorageClassName { get; set; }

        /// <summary>
        /// Gets or sets storageOS represents a StorageOS volume that is
        /// attached to the kubelet's host machine and mounted into the pod
        /// More info: https://examples.k8s.io/volumes/storageos/README.md
        /// </summary>
        [JsonProperty(PropertyName = "storageos")]
        public V1StorageOSPersistentVolumeSource Storageos { get; set; }

        /// <summary>
        /// Gets or sets volumeMode defines if a volume is intended to be used
        /// with a formatted filesystem or to remain in raw block state. Value
        /// of Filesystem is implied when not included in spec.
        /// </summary>
        [JsonProperty(PropertyName = "volumeMode")]
        public string VolumeMode { get; set; }

        /// <summary>
        /// Gets or sets vsphereVolume represents a vSphere volume attached and
        /// mounted on kubelets host machine
        /// </summary>
        [JsonProperty(PropertyName = "vsphereVolume")]
        public V1VsphereVirtualDiskVolumeSource VsphereVolume { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AwsElasticBlockStore != null)
            {
                AwsElasticBlockStore.Validate();
            }
            if (AzureDisk != null)
            {
                AzureDisk.Validate();
            }
            if (AzureFile != null)
            {
                AzureFile.Validate();
            }
            if (Cephfs != null)
            {
                Cephfs.Validate();
            }
            if (Cinder != null)
            {
                Cinder.Validate();
            }
            if (Csi != null)
            {
                Csi.Validate();
            }
            if (FlexVolume != null)
            {
                FlexVolume.Validate();
            }
            if (GcePersistentDisk != null)
            {
                GcePersistentDisk.Validate();
            }
            if (Glusterfs != null)
            {
                Glusterfs.Validate();
            }
            if (HostPath != null)
            {
                HostPath.Validate();
            }
            if (Iscsi != null)
            {
                Iscsi.Validate();
            }
            if (Local != null)
            {
                Local.Validate();
            }
            if (Nfs != null)
            {
                Nfs.Validate();
            }
            if (NodeAffinity != null)
            {
                NodeAffinity.Validate();
            }
            if (PhotonPersistentDisk != null)
            {
                PhotonPersistentDisk.Validate();
            }
            if (PortworxVolume != null)
            {
                PortworxVolume.Validate();
            }
            if (Quobyte != null)
            {
                Quobyte.Validate();
            }
            if (Rbd != null)
            {
                Rbd.Validate();
            }
            if (ScaleIO != null)
            {
                ScaleIO.Validate();
            }
            if (VsphereVolume != null)
            {
                VsphereVolume.Validate();
            }
        }
    }
}
