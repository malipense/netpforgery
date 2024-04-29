# netpforgery
Forging and sending packets with pcap.

# Currently supports:
  - Loopback
  - Ethernet
  - Ipv4
  - Arp (request/reply)

# How to use it:
  1. Have [Npcap](https://npcap.com/#download) installed on your computer. If you have [Wireshark](https://www.wireshark.org/download.html) installed you likely already have it.
  2. Add a reference to this project on your app.
  3. Create a PcapModule object: `PcapModule module = new PcapModule()`
     - `m.ListNetworkDevices()` returns the list of network devices.
     - `module.Open(deviceName)` opens a device to send data. Returns a IntPtr referencing the device.
     - `module.Send(deviceReference, byte[] packet, int size)` sends data down the interface.
     - `BinaryConverter` and `DatagramProvider` helps you with creating and converting data structures to bytes. 
