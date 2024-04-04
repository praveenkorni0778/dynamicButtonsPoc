
export const Buttons = (props:any) => {
    let btns = props?.buttons;

    return (
        <div>  
        {
            btns && btns?.map((btn:any) => <button type={btn?.type}>{btn?.displayName}</button>)
        }

        </div>
    )
}