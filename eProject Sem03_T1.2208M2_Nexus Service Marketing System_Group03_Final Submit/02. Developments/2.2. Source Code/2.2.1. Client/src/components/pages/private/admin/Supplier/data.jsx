/* eslint-disable react/prop-types */
import { DefaultCell } from "../../../../models";
import { UIButton } from "../../../../common";
import { useDispatch, useSelector } from "react-redux";
import {
  setStatus,
  setStatusModal,
  setType,
  setValue,
} from "../../../../../context/modalSlice";
import Detail_Supplier from "./Detail";
import { useSupplier } from "../../../../../hooks/useSupplier";
import Swal from "sweetalert2";
const dataApiSupplier = [
  {
    id: 1,
    brand_name: "misubisi",
    phone: "0971866177",
    address: "ha noi",
  },
  {
    id: 2,
    phone: "0971823423",
    brand_name: "panasonic",
    address: "ho chi minh",
  },
  {
    id: 3,
    phone: "09718213414",
    brand_name: "viettel",
    address: "da nang",
  },
];
const data = {
  columns: [
    {
      Header: "Brand Name",
      accessor: "brand_name",
      Cell: ({ value }) => <DefaultCell value={value} />,
    },
    {
      Header: "phone",
      accessor: "phone",
      Cell: ({ value }) => <DefaultCell value={value} />,
    },
    {
      Header: "address",
      accessor: "address",
      Cell: ({ value }) => <DefaultCell value={value} />,
    },
    {
      Header: "Action",
      accessor: "id",
      Cell: ({ value }) => {
        const dispatch = useDispatch();
        const handleChangeModal = () => {
          dispatch(setStatus(true));
          dispatch(setType(Detail_Supplier));
          dispatch(setValue(value));
        };
        const handleDelete = () => {
          const data = { supplier_id: value };
          console.log(data);
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
            <UIButton color="error" onClick={handleDelete}>
              Delete
            </UIButton>
          </>
        );
      },
    },
  ],

  rows: dataApiSupplier,
};
const columns = [
  {
    Header: "Brand Name",
    accessor: "brand_name",
    Cell: ({ value }) => <DefaultCell value={value} />,
  },
  {
    Header: "phone",
    accessor: "phone",
    Cell: ({ value }) => <DefaultCell value={value} />,
  },
  {
    Header: "address",
    accessor: "address",
    Cell: ({ value }) => <DefaultCell value={value} />,
  },
  {
    Header: "Action",
    accessor: "id",
    Cell: ({ value }) => {
      const { handleDelete } = useSupplier();
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
            text: "You want delete supplier!",
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
        dispatch(setType(Detail_Supplier));
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
export { dataApiSupplier, data, columns };
