/* eslint-disable react/prop-types */
import { DefaultCell } from "../../../../models";
import { UIButton } from "../../../../common";
import { useDispatch } from "react-redux";
import {
  setStatus,
  setStatusModal,
  setType,
  setValue,
} from "../../../../../context/modalSlice";
import Detail_Product from "./Detail";
import { dataApiSupplier } from "../Supplier/data";
import { dataApi } from "../Package/data";
import { axiosAuthentication } from "../../../../../../http";
import { useProduct } from "../../../../../hooks/useProduct";
import Swal from "sweetalert2";
const dataApiProduct = [
  {
    id: 1,
    name: "call nasa",
    numb_connect: 1000,
    connect_type_id: 1,
    supplier_id: 1,
  },
  {
    id: 2,
    name: "call people",
    numb_connect: 10,
    connect_type_id: 2,
    supplier_id: 2,
  },
  {
    id: 1,
    name: "call animal",
    numb_connect: 123,
    connect_type_id: 3,
    supplier_id: 1,
  },
];

const handleRows = async (data) => {
  const rows = [];
  const urlS = "http://localhost:8000/api/Supplier";
  const urlC = "http://localhost:8000/api/ConnectType";
  let dataSuplier;
  await axiosAuthentication.get(urlS).then(async (res) => {
    if (res.status == 200) {
      dataSuplier = res.data.map((item) => {
        const { brandName, ...rest } = item;
        const newItem = rest;
        newItem.brand_name = brandName;
        return newItem;
      });
    }
  });
  let dataConnectType;
  await axiosAuthentication.get(urlC).then(async (res) => {
    if (res.status == 200) {
      dataConnectType = res.data.map((item) => {
        const { brandName, ...rest } = item;
        const newItem = rest;
        newItem.brand_name = brandName;
        return newItem;
      });
    }
  });
  data.map((item) => {
    const newItem = { ...item };
    newItem.supplier = dataSuplier.find(
      ({ id }) => id == item.supplier_id
    ).brand_name;
    newItem.connect_type = dataConnectType.find(
      ({ id }) => id == item.connect_type_id
    ).name;
    return rows.push(newItem);
  });
  return rows;
};
const data = {
  columns: [
    {
      Header: "Name",
      accessor: "name",
      Cell: ({ value }) => <DefaultCell value={value} />,
    },
    {
      Header: "number connect",
      accessor: "numb_connect",
      Cell: ({ value }) => <DefaultCell value={value} />,
    },
    {
      Header: "type connect",
      accessor: "connect_type",
      Cell: ({ value }) => <DefaultCell value={value} />,
    },
    {
      Header: "Supplier",
      accessor: "supplier",
      Cell: ({ value }) => <DefaultCell value={value} />,
    },
    {
      Header: "Action",
      accessor: "id",
      Cell: ({ value }) => {
        const dispatch = useDispatch();
        const handleChangeModal = () => {
          dispatch(setStatus(true));
          dispatch(setType(Detail_Product));
          dispatch(setValue(value));
        };
        const handleDel = async () => {
          await showAlert();
        };
        return (
          <>
            <UIButton
              variant={"outlined"}
              color="info"
              onClick={handleChangeModal}
              sx={() => ({ margin: "0 1rem" })}>
              Edit
            </UIButton>
            <UIButton color="error" onClick={handleDel}>
              Delete
            </UIButton>
          </>
        );
      },
    },
  ],

  // rows: handleRows(),
};

const columns = [
  {
    Header: "Name",
    accessor: "name",
    Cell: ({ value }) => <DefaultCell value={value} />,
  },
  {
    Header: "number connect",
    accessor: "numb_connect",
    Cell: ({ value }) => <DefaultCell value={value} />,
  },
  {
    Header: "type connect",
    accessor: "connect_type",
    Cell: ({ value }) => <DefaultCell value={value} />,
  },
  {
    Header: "Supplier",
    accessor: "supplier",
    Cell: ({ value }) => <DefaultCell value={value} />,
  },
  {
    Header: "Action",
    accessor: "id",
    Cell: ({ value }) => {
      const { handleDelete } = useProduct();
      const showAlert = async () => {
        const newSwal = Swal.mixin({
          customClass: {
            confirmButton: "button button-success",
            cancelButton: "button button-error",
          },
          buttonsStyling: false,
        });

        return newSwal
          .fire({
            title: "Are you sure?",
            text: "You want delete product!",
            icon: "warning",
            showCancelButton: true,
            confirmButtonText: "Yes, delete!",
          })
          .then(async (result) => {
            if (result.isConfirmed) {
              await handleDelete({ id: value });
              dispatch(setStatusModal());
              return Swal.fire("Delete!", "Your has been delete.", "success");
            }
          });
      };
      const dispatch = useDispatch();
      const handleChangeModal = () => {
        dispatch(setStatus(true));
        dispatch(setType(Detail_Product));
        dispatch(setValue(value));
      };

      const handleDel = async () => {
        await showAlert();
      };
      return (
        <>
          <UIButton
            variant={"outlined"}
            color="info"
            onClick={handleChangeModal}
            sx={() => ({ margin: "0 1rem" })}>
            Edit
          </UIButton>
          <UIButton color="error" onClick={handleDel}>
            Delete
          </UIButton>
        </>
      );
    },
  },
];
export { dataApiProduct, data, handleRows, columns };
